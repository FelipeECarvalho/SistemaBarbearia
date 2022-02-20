using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
		public List<Agendamento> Agendamentos { get; set; }
		public Cliente() { }

		public Cliente(string cpf, string nome, string telefone, string email)
		{
			Cpf = cpf;
			Nome = nome;
			Telefone = telefone;
			Email = email;
		}
	}
}
