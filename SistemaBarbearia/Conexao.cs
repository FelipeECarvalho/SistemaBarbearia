using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SistemaBarbearia
{
	class Conexao : IDisposable
	{
		public Conexao()
		{
			Database.Connection = new SqlConnection("Server=localhost,1433;Database=Barbearia;UserId=sa;Password= 1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;");

			Database.Connection.Open();
		}

		public void Dispose()
		{
			if (Database.Connection.State == ConnectionState.Open)
				Database.Connection.Close();
		}
	}
}
