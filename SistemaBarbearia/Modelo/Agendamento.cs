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

		[ForeignKey("IdCliente")]
		public Cliente Cliente { get; set; }
		public string NomeCliente { get { return Cliente.Nome; } }
		public DateTime Data { get; set; }
		public decimal ValorTotal { get; set; }

		public readonly List<Servico> Servicos;

		public Agendamento()
		{
			Servicos = new List<Servico>();
		}

		public void InsertServico(List<Servico> servico) 
		{
			Servicos.AddRange(servico);
		}
	}
}
