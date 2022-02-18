using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class ClienteControle : ControleBase
	{
		private readonly ClienteRepositorio _clienteRepositorio;

		public bool Create(Cliente cliente)
		{
			try
			{
				if (string.IsNullOrEmpty(cliente.Cpf.Trim()) || string.IsNullOrEmpty(cliente.Nome.Trim())|| string.IsNullOrEmpty(cliente.Email.Trim()) || string.IsNullOrEmpty(cliente.Telefone.Trim())) throw new NullReferenceException();

				_clienteRepositorio.Create(cliente);

				OnControleSuccessfullyAction("Cliente criado com sucesso!", "Cliente");
				return true;
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não pode ser criado. Verifique os dados.", "Cliente"); }

			return false;
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
			try
			{
				if (id <= 0) throw new NullReferenceException();
				return _clienteRepositorio.Get(id) ?? throw new NullReferenceException();
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não encontrado. Verifique os dados.", "Cliente"); }

			return null;
		}

		public IEnumerable<Cliente> Get()
		{
			return _clienteRepositorio.Get();
		}

		public void Update(Cliente cliente)
		{
			try
			{
				if (string.IsNullOrEmpty(cliente.Cpf.Trim()) || string.IsNullOrEmpty(cliente.Nome.Trim()) || string.IsNullOrEmpty(cliente.Email.Trim()) || string.IsNullOrEmpty(cliente.Telefone.Trim())) throw new NullReferenceException();

				_clienteRepositorio.Update(cliente);
				OnControleSuccessfullyAction("Cliente atualizado com sucesso!", "Cliente");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não pode ser atualizado. Verifique os dados.", "Cliente"); }
		}

		public void Delete(Cliente cliente)
		{
			try
			{
				if (string.IsNullOrEmpty(cliente.Cpf)) throw new NullReferenceException();

				if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Exclusão", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

				_clienteRepositorio.Delete(cliente);
				OnControleSuccessfullyAction("Cliente excluído com sucesso!", "Cliente");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Cliente não encontrado. Verifique os dados.", "Cliente"); }
		}

		public List<Cliente> FindClientes(string param) 
		{
			if (string.IsNullOrEmpty(param)) return null;
			return _clienteRepositorio.FindClientes(param).ToList();
		}

		public ClienteControle() => _clienteRepositorio = new ClienteRepositorio();

	}
}
