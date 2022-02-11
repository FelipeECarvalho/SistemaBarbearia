using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBarbearia.Modelo
{
	[Table("Agendamento")]
	public class Agendamento
	{
		public int Id { get; set; }
		public int IdCliente { get; set; }
		public DateTime Data { get; set; }
		public decimal ValorTotal { get; set; }

		public readonly List<Servico> Servicos;
		public Cliente Cliente { get; set; }

		public Agendamento()
		{
			Servicos = new List<Servico>();
		}
	}
}
