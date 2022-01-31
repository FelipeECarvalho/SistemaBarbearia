using System.Collections.Generic;
using SistemaBarbearia.Modelo;
using System.Data;
using SistemaBarbearia.Repositorio;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly ClienteRepositorio _clienteRepositorio;

		public void Create(Cliente cliente)
		{
			if (!(cliente == null))
			{
				using (var conexao = new Conexao())
				{
					_clienteRepositorio.Create(cliente);
				}
			}
		}
		public Cliente Get(string cpf)
		{
			using (var conexao = new Conexao())
			{
				return _clienteRepositorio.Get(cpf);
			}
		}

		public IEnumerable<Cliente> GetAll()
		{
			using (var conexao = new Conexao())
			{
				return _clienteRepositorio.Get();
			}
		}

		public DataTable GetDataTable()
		{
			using (var conexao = new Conexao())
			{
				var clientes = _clienteRepositorio.Get().ToList();
				return _clienteRepositorio.GetDataTable(clientes);
			}
		}

		public void Update(Cliente cliente)
		{
			using (var conexao = new Conexao())
			{
				_clienteRepositorio.Update(cliente);
			}
		}

		public void Delete(Cliente cliente) 
		{
			using (var conexao = new Conexao())
			{
				_clienteRepositorio.Delete(cliente);
			}
		}

		public ClienteControle()
		{
			_clienteRepositorio = new ClienteRepositorio();
		}

	}
}
