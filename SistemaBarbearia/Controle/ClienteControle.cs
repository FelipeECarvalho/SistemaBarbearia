using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
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
			try
			{
				if (string.IsNullOrEmpty(cpf)) throw new NullReferenceException();
				return _clienteRepositorio.Get(cpf) ?? throw new NullReferenceException();
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não encontrado. Verifique os dados.", "Cliente"); }

			return null;
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
			try
			{
				if (cliente == null) throw new NullReferenceException();

				_clienteRepositorio.Delete(cliente);

				OnControleSuccessfullyAction("Cliente excluído com sucesso!", "Cliente");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não encontrado. Verifique os dados.", "Cliente"); }
		}

		public ClienteControle() => _clienteRepositorio = new ClienteRepositorio();

	}
}
