using System.Collections.Generic;
using SistemaBarbearia.Modelo;
using System.Data;
using SistemaBarbearia.Repositorio;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly RepositorioBase<Cliente> _repositorio;

		public ClienteControle()
		{
			_repositorio = new RepositorioBase<Cliente>();
		}

		public void Create(Cliente cliente)
		{
			if (!(cliente == null))
			{
				using (var conexao = new Conexao())
				{
					_repositorio.Create(cliente);
				}
			}
		}

		public IEnumerable<Cliente> GetAll()
		{
			using (var conexao = new Conexao())
			{
				return _repositorio.Get();
			}
		}

		public DataTable GetDataTable()
		{
			using (var conexao = new Conexao())
			{
				var clientes = _repositorio.Get().ToList();
				return _repositorio.GetDataTable(clientes);
			}
		}

		public void Delete(int id)
		{
			using (var conexao = new Conexao())
			{
				_repositorio.Delete(id);
			}
		}
		public void Delete(Cliente cliente) 
		{
			using (var conexao = new Conexao())
			{
				_repositorio.Delete(cliente);
			}
		}

		public Cliente Get(int id)
		{
			using (var conexao = new Conexao())
			{
				return _repositorio.Get(id);
			}
		}

		public void Update(Cliente cliente)
		{
			using (var conexao = new Conexao())
			{
				_repositorio.Update(cliente);
			}
		}
	}
}
