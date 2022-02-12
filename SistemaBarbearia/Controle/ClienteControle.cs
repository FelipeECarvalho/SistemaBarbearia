using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly ClienteRepositorio _clienteRepositorio;

		public void Create(Cliente cliente)
		{
			_clienteRepositorio.Create(cliente);
		}
		public Cliente Get(string cpf)
		{
			return _clienteRepositorio.Get(cpf);
		}

		public Cliente Get(int id)
		{
			return _clienteRepositorio.Get(id);
		}

		public IEnumerable<Cliente> Get()
		{
			return _clienteRepositorio.Get();
		}

		public void Update(Cliente cliente)
		{
			_clienteRepositorio.Update(cliente);
		}

		public void Delete(Cliente cliente)
		{
			_clienteRepositorio.Delete(cliente);
		}

		public ClienteControle() => _clienteRepositorio = new ClienteRepositorio();

	}
}
