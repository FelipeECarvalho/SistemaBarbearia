using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	[Table("Cliente")]
	public class Cliente
	{
		public int Id { get;  }
		public string Cpf { get; }
		public string Nome { get; private set; }
		public string Telefone { get; private set; }
		public string Email { get; private set; }

		public Cliente(string cpf, string nome, string telefone, string email)
		{
			Cpf = cpf;
			Nome = nome;
			Telefone = telefone;
			Email = email;
		}

		public void SetNome(string nome)
		{
			if (!string.IsNullOrEmpty(nome)) 
			{
				Nome = nome;
			}
		}

		public void SetEmail(string email)
		{
			if (!string.IsNullOrEmpty(email))
			{
				Email = email;
			}
		}

		public void SetTelefone(string telefone)
		{
			if (!string.IsNullOrEmpty(telefone))
			{
				Telefone = telefone;
			}
		}

	}
}
