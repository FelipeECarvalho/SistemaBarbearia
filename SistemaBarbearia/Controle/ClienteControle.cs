using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Data;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly ClienteRepositorio _clienteRepositorio;

		public void Create(Cliente cliente)
		{
			if (!(string.IsNullOrEmpty(cliente.Nome)))
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

		public Cliente Get(int id)
		{
			using (var conexao = new Conexao())
			{
				return _clienteRepositorio.Get(id);
			}
		}

		public DataTable GetDataTable()
		{
			using (var conexao = new Conexao())
			{
				return _clienteRepositorio.GetDataTable(_clienteRepositorio.Get().ToList());
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
