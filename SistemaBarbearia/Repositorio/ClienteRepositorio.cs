using Microsoft.Data.SqlClient;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class ClienteRepositorio : RepositorioBase<Cliente>
	{
		public ClienteRepositorio() 
		{
		}

		public Cliente Get(string cpf)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Clientes.FirstOrDefault(x => x.Cpf == cpf);
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível acessar cliente. Verifique a conexão."); }

			return null;
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
