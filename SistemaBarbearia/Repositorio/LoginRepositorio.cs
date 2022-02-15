using Microsoft.Data.SqlClient;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase<Administrador>
	{
		public LoginRepositorio() 
		{
			_context = new BarbeariaDbContext();
		}
		public Administrador Acessar(string usuario, string senha)
		{
			try
			{
				return _context.Administradores
				.SingleOrDefault(x => x.Senha == senha && x.Usuario == usuario);
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return null;
		}
	}
}
