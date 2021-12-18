using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SistemaBarbearia.DAL
{
	class ClienteComandos
	{
		SqlCommand cmd = new SqlCommand();
		Conexao con = new Conexao();

		public void CadastrarCliente(string cpf, string nome, string telefone, string email)
		{
			cmd.CommandText = "INSERT INTO Clientes(NOME, CPF, EMAIL, TELEFONE) values(@nome, @cpf, @email, @telefone)";

			cmd.Parameters.AddWithValue("@nome", nome);
			cmd.Parameters.AddWithValue("@cpf", cpf);
			cmd.Parameters.AddWithValue("@email", email);
			cmd.Parameters.AddWithValue("@telefone", telefone);

			try
			{
				cmd.Connection = con.Conectar();
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


		public List<Cliente> GetAllClientes()
		{
			List<Cliente> clientes = new List<Cliente>();
			cmd.CommandText = "SELECT CPF, NOME, TELEFONE, EMAIL FROM CLIENTES";
			try
			{
				cmd.Connection = con.Conectar();
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						clientes.Add(new Cliente(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
					}
				}
				return clientes;
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


		public DataTable ClienteDataTable()
		{
			cmd.CommandText = "SELECT CPF, NOME, TELEFONE, EMAIL FROM CLIENTES";
			try
			{
				using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, con.Conectar()))
				{
					using (DataTable tableCliente = new DataTable())
					{
						dataAdapter.Fill(tableCliente);
						return tableCliente;
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


		public void ExcluirCliente(string cpf)
		{
			cmd.CommandText = "DELETE FROM CLIENTES WHERE CPF = '" + cpf + "'";
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



		public Cliente GetCliente(string cpf)
		{
			cmd.CommandText = "SELECT CPF, NOME, TELEFONE, EMAIL FROM CLIENTES WHERE CPF = '" + cpf + "'";
			cmd.Connection = con.Conectar();
			Cliente cliente = null;
			try
			{
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					cliente = new Cliente(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
				}
				return cliente;
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



		public void UpdateCliente(string cpf, string nome, string telefone, string email)
		{
			cmd.CommandText = "UPDATE CLIENTES SET NOME = '" + nome + "', TELEFONE = '" + telefone + "', EMAIL = '" + email + "' WHERE CPF = '" + cpf + "'";
			try
			{
				cmd.Connection = con.Conectar();
				cmd.ExecuteNonQuery();
				con.Desconectar();

			}
			catch (SqlException e)
			{
				throw new ApplicationException(e.Message);
			}
		}


	}
}
