using SistemaBarbearia.Exception;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace SistemaBarbearia.DAL
{
	class LoginRepositorio
	{
		SqlCommand cmd = new SqlCommand();
		Database con = new Database();

		public Administrador AcessoAdm(string usuario, string senha)
		{
			Administrador adm = new Administrador();

			cmd.CommandText = "SELECT Nome FROM ADMINISTRADORES WHERE Senha = '" + senha + "' AND Usuario = '" + usuario + "'";

			cmd.Connection = con.Conectar();
			try
			{

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					adm.Nome = reader[0].ToString();
				}
				return adm;
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
