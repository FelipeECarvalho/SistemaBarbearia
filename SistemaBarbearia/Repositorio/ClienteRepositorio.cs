using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBarbearia.Repositorio
{
	class ClienteRepositorio : RepositorioBase<Cliente>
	{
		public ClienteRepositorio() 
		{
		}

		public async Task<Cliente> GetAsync(string cpf)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return await _context.Clientes.FirstOrDefaultAsync(x => x.Cpf == cpf);
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível acessar cliente. Verifique a conexão."); }

			return await Task.FromResult<Cliente>(null);
		}

		public IEnumerable<Cliente> FindClientes(string param) 
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Clientes.Where(x => x.Nome.Contains(param) || x.Cpf.Contains(param)).ToList();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível acessar cliente. Verifique a conexão."); }

			return null;
		}

	}
}
