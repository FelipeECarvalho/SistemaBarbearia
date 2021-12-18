using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	public class Cliente
	{
		public string Nome { get; }
		public string Cpf { get; }
		public string Email { get; }
		public string Telefone { get; }

		public Cliente() 
		{
		}

		public Cliente(string cpf, string nome, string telefone, string email)
		{
			Nome = nome;
			Cpf = cpf;
			Email = email;
			Telefone = telefone;
		}

		public override string ToString()
		{
			return $"{Nome} - {Telefone}";
		}
	}
}
