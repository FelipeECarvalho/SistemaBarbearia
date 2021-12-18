using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SistemaBarbearia.DAL
{
	class ServicoComandos
	{
		SqlCommand cmd = new SqlCommand();
		Conexao con = new Conexao();


		public List<Servico> GetAllServicos()
		{
			cmd.CommandText = "SELECT ID, DESCRICAO, VALOR FROM SERVICOS";
			cmd.Connection = con.Conectar();
			List<Servico> servicos = new List<Servico>();

			try
			{
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					servicos.Add(new Servico((int)reader[0], reader[1].ToString(), (decimal)reader[2]));
				}
				return servicos;
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
