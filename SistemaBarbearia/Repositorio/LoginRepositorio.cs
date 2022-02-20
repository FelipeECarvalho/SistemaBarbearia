using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Threading.Tasks;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase<Administrador>
	{
		public LoginRepositorio()
		{
		}
		public async Task<Administrador> AcessarAsync(string usuario, string senha)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{

					return await _context.Administradores
								.FirstOrDefaultAsync(x => x.Senha == senha && x.Usuario == usuario);
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return await Task.FromResult<Administrador>(null);
		}
	}
}
