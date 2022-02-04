using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly ClienteRepositorio _clienteRepositorio;

		public void Create(Cliente cliente)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					_clienteRepositorio.Create(cliente);
				}

			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel cadastrar o cliente. Verifique a conexão. {e.Source}"); }
		}

		public Cliente Get(string cpf)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _clienteRepositorio.Get(cpf);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar o cliente. Verifique a conexão. {e.Source}"); }

			return null;
		}

		public Cliente Get(int id)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _clienteRepositorio.Get(id);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar o cliente. Verifique a conexão. {e.Source}"); }

			return null;
		}

		public DataTable GetDataTable()
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _clienteRepositorio.GetDataTable(_clienteRepositorio.Get().ToList());
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os dados da tabela. Verifique a conexão. {e.Source}"); }

			return null;
		}

		public void Update(Cliente cliente)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					_clienteRepositorio.Update(cliente);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel atualizar o cliente. Verifique a conexão. {e.Source}"); }
		}

		public void Delete(Cliente cliente)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					_clienteRepositorio.Delete(cliente);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel deletar o cliente. Verifique a conexão. {e.Source}"); }
		}

		public ClienteControle() => _clienteRepositorio = new ClienteRepositorio();

	}
}
