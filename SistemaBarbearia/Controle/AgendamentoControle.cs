using SistemaBarbearia.DAL;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaBarbearia.Controle
{
	class AgendamentoControle
	{
		AgendamentoRepositorio agendamentoComandos = new AgendamentoRepositorio();

		public AgendamentoControle()
		{
		}

		public bool InserirAgendamento(string cpf, DateTime data, decimal valor, List<Servico> servicos)
		{
			if (DateTime.Now.Date > data.Date || servicos.Count == 0 || string.IsNullOrEmpty(cpf))
			{
				return false;
			}
			else
			{
				agendamentoComandos.InserirAgendamento(cpf, data, valor, servicos);
				return true;
			}
		}

		public List<DateTime> GetDatas(DateTime data)
		{
			return agendamentoComandos.GetDatas(data);
		}

		public DataTable GetAgendamentoTable(string data = null)
		{
			return agendamentoComandos.AgendamentoDataTable(data);
		}

		public Agendamento GetAgendamento(DateTime data)
		{
			return agendamentoComandos.GetAgendamento(data);
		}
	}
}
