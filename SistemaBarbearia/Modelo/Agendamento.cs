using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	class Agendamento
	{
		public Cliente Cliente { get; }
		public decimal ValorTotal { get; }
		public List<Servico> Servicos { get; }
		public DateTime Data { get; }

		public Agendamento()
		{
		}

		public Agendamento(Cliente cliente, decimal valorTotal, List<Servico> servicos, DateTime data)
		{
			Cliente = cliente;
			ValorTotal = valorTotal;
			Servicos = servicos;
			Data = data;
		}
	}
}
