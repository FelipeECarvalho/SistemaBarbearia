using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace SistemaBarbearia.DAL
{
	class AgendamentoComandos
	{
		SqlCommand cmd = new SqlCommand();
		Conexao con = new Conexao();
		ClienteComandos clienteCmd = new ClienteComandos();


		public void InserirAgendamento(string cpf, DateTime data, decimal valor, List<Servico> servicos)
		{
			cmd.CommandText = "INSERT INTO AGENDAMENTOS(CPF_CLIENTE, DATA, VALOR_TOTAL) VALUES (@cpf, @data, @valor)";
			cmd.Parameters.AddWithValue("@cpf", cpf);
			cmd.Parameters.AddWithValue("@data", data);
			cmd.Parameters.AddWithValue("@valor", valor);
			try
			{

				cmd.Connection = con.Conectar();
				cmd.ExecuteNonQuery();
				foreach (Servico s in servicos)
				{

					cmd.CommandText = "INSERT INTO SERVICOS_DO_AGENDAMENTO(ID_AGENDAMENTO, ID_SERVICO) SELECT (SELECT MAX(ID) FROM AGENDAMENTOS), ID FROM SERVICOS WHERE ID = " + s.Id;
					cmd.ExecuteNonQuery();

				}
			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
			finally
			{
				con.Desconectar();
			}
		}


		public List<DateTime> GetDatas(DateTime data)
		{
			cmd.CommandText = "SELECT DATA FROM AGENDAMENTOS WHERE DAY(DATA) = '" + data.Day + "' AND MONTH(DATA) = '" + data.Month + "' AND YEAR(DATA) = '" + data.Year + "'";

			cmd.Connection = con.Conectar();
			List<DateTime> datas = new List<DateTime>();

			try
			{
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					datas.Add(DateTime.ParseExact(reader[0].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
				}
				return datas;
			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
			finally
			{
				con.Desconectar();
			}

		}
		public DataTable AgendamentoDataTable(string dataString = null)
		{
			if (dataString != null)
			{
				DateTime data = DateTime.Parse(dataString);
				cmd.CommandText = "SELECT CONVERT(VARCHAR(11),DATA,114) AS HORA, C.NOME FROM AGENDAMENTOS A INNER JOIN CLIENTES C ON A.CPF_CLIENTE = C.CPF WHERE DAY(DATA) = " + data.Day + " AND MONTH(DATA) = " + data.Month + " AND YEAR(DATA) = " + data.Year + " ORDER BY 1";
			}
			else
			{
				cmd.CommandText = "SELECT A.DATA, C.NOME FROM AGENDAMENTOS A INNER JOIN CLIENTES C ON A.CPF_CLIENTE = C.CPF ORDER BY 1";
			}
			try
			{
				using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, con.Conectar()))
				{
					using (DataTable tableAgendamento = new DataTable())
					{
						dataAdapter.Fill(tableAgendamento);
						return tableAgendamento;
					}
				}
			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
			finally
			{
				con.Desconectar();
			}
		}

		public Agendamento GetAgendamento(DateTime data)
		{
			List<Servico> servicos = new List<Servico>();
			Cliente cliente = new Cliente();
			decimal valor = 0;

			cmd.CommandText = "SELECT CPF_CLIENTE, VALOR_TOTAL, ID FROM AGENDAMENTOS WHERE DATA = '" + data + "'";

			cmd.Connection = con.Conectar();

			try
			{
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					cliente = clienteCmd.GetCliente(reader[0].ToString());
					valor = (decimal)reader[1];
				}
				cmd.CommandText = "SELECT S.ID, S.DESCRICAO, S.VALOR FROM SERVICOS_DO_AGENDAMENTO A INNER JOIN SERVICOS S ON A.ID_SERVICO = S.ID WHERE ID_AGENDAMENTO = " + reader[2].ToString();

				reader.Close();
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					servicos.Add(new Servico((int)reader[0], reader[1].ToString(), (decimal)reader[2]));
				}
				return new Agendamento(cliente, valor, servicos, data);
			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
			finally
			{
				con.Desconectar();
			}
		}
		public void ExcluirAgendamento(DateTime data)
		{
			cmd.CommandText = "DELETE FROM AGENDAMENTOS WHERE DATA = '" + data + "'";
			cmd.Connection = con.Conectar();
			try
			{
				cmd.ExecuteNonQuery();

			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
			finally
			{
				con.Desconectar();
			}
		}
	}
}
