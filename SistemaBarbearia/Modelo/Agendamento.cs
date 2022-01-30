using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	[Table("Agendamento")]
	class Agendamento
	{
		public int Id { get; }
		public int IdCliente { get; }
		public DateTime Data { get; }
		public decimal ValorTotal { get; }
		[Write(false)]
		public List<Servico> Servicos { get; }
		

	}
}
