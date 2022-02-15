using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;

namespace SistemaBarbearia.Controle
{
	class AgendamentoControle : ControleBase
	{
		private readonly AgendamentoRepositorio _agendamentoRepositorio;

		public AgendamentoControle() => _agendamentoRepositorio = new AgendamentoRepositorio();


		public void Create(Agendamento agendamento)
		{
			try
			{
				if (agendamento == null) throw new NullReferenceException();

				_agendamentoRepositorio.Create(agendamento);

				OnControleSuccessfullyAction("Agendamento criado com sucesso!", "Agendamento");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Agendamento não pode ser criado. Verifique os dados.", "Cliente"); }

		}

		public IEnumerable<Agendamento> Get()
		{
			return _agendamentoRepositorio.Get();
		}

		public IEnumerable<Agendamento> GetMenu(DateTime data)
		{
			return _agendamentoRepositorio.GetMenuList(data);
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			return _agendamentoRepositorio.GetDatasAgendadas(data);
		}

		public void Delete(Agendamento agendamento)
		{
			try
			{
				if (agendamento == null) throw new NullReferenceException();
				_agendamentoRepositorio.Delete(agendamento);

				OnControleSuccessfullyAction("Agendamento excluído com sucesso!", "Agendamento");
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Agendamento não pode ser criado. Verifique os dados.", "Cliente"); }
		}

	}
}
