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
		public string Nome { get; }
		public string Telefone { get; }
		public string Email { get; }
	}
}
