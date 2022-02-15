using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase
	{
		public Administrador Acessar(string usuario, string senha)
		{
			try
			{
				return context.Administradores
				.SingleOrDefault(x => x.Senha == senha && x.Usuario == usuario);
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados, tente novamente."); }

			return null;
		}
	}
}
