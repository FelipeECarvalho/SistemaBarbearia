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
			_context = new BarbeariaDbContext();
		}

		public Cliente Get(string cpf)
		{
			try
			{
				return _context.Clientes.FirstOrDefault(x => x.Cpf == cpf);
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível acessar cliente. Verifique a conexão."); }

			return null;
		}

		public IEnumerable<Cliente> FindClientes(string param) 
		{
			try
			{
				return _context.Clientes.Where(x => x.Nome == param && x.Cpf == param).ToList();
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Não foi possível acessar cliente. Verifique a conexão."); }

			return null;
		}

	}
}
