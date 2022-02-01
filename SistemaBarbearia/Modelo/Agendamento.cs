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
		public int IdCliente { get; set; }
		public DateTime Data { get; set; }
		public decimal ValorTotal { get; set; }
		[Write(false)]
		public List<Servico> Servicos { get; set; }
		

	}
}
