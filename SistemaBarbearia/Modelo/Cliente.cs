using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace SistemaBarbearia.Modelo
{
	[Table("Cliente")]
	public class Cliente
	{
		public int Id { get; set; }
		public string Cpf { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }

		public readonly List<Agendamento> Agendamentos;

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
