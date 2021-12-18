using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SistemaBarbearia.DAL
{
	class Conexao
	{
		SqlConnection con = new SqlConnection("Data Source=FELIPECARVALHO;Initial Catalog=SistemaBarbeariaBd;Integrated Security=True");

		public Conexao() 
		{
		}

		public SqlConnection Conectar() 
		{

			if (con.State == System.Data.ConnectionState.Closed) 
			{
				con.Open();
			}
			return con;
		}

		public void Desconectar()
		{
			if (con.State == System.Data.ConnectionState.Open)
			{
				con.Close();
			}
		}

	}
}
