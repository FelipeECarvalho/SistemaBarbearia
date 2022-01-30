using System;
using System.Collections.Generic;
using System.Text;
using SistemaBarbearia.Exception;
using SistemaBarbearia.DAL;
using SistemaBarbearia.Modelo;
using System.Data;

namespace SistemaBarbearia.Controle
{
	class ClienteControle
	{
		ClienteRepositorio clienteComandos = new ClienteRepositorio();

		public ClienteControle()
		{
		}

		public void Cadastrar(string cpf, string nome, string telefone, string email)
		{
			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefone))
			{
				throw new BdCadastroException("Erro ao cadastrar, verifique os valores");
			}
			clienteComandos.CadastrarCliente(cpf, nome, telefone, email);
		}

		public List<Cliente> GetAllClientes()
		{
			return clienteComandos.GetAllClientes();
		}

		public DataTable GetClienteTable()
		{
			return clienteComandos.ClienteDataTable();
		}

		public void ExcluirCliente(string cpf)
		{
			clienteComandos.ExcluirCliente(cpf);
		}

		public Cliente GetCliente(string cpf)
		{
			return clienteComandos.GetCliente(cpf);
		}

		public bool UpdateCliente(string cpf, string nome, string telefone, string email)
		{
			if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone))
			{
				return false;
			}
			else
			{
				clienteComandos.UpdateCliente(cpf, nome, telefone, email);
				return true;
			}
		}
	}
}
