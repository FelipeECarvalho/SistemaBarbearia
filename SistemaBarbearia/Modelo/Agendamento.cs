using Dapper.Contrib.Extensions;
using SistemaBarbearia.Controle;
using System;
using System.Collections.Generic;

namespace SistemaBarbearia.Modelo
{
	[Table("Agendamento")]
	class Agendamento
	{
		public int Id { get; set; }
		public int IdCliente { get; set; }
		public DateTime Data { get; set; }
		public decimal ValorTotal { get; set; }

		[Write(false)]
		public List<Servico> Servicos { get; set; }
		[Write(false)]
		public string NomeCliente
		{
			get
			{
				return _clienteControle.Get(IdCliente).Nome;
			}
			set
			{
				NomeCliente = value;
			}
		}

		private ClienteControle _clienteControle;

		public Agendamento()
		{
			Servicos = new List<Servico>();
			_clienteControle = new ClienteControle();
		}
	}
}
