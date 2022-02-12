using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class AgendamentoControle : ControleBase
	{
		private readonly AgendamentoRepositorio _agendamentoRepositorio;

		public AgendamentoControle() => _agendamentoRepositorio = new AgendamentoRepositorio();


		public void Create(Agendamento agendamento, List<Servico> servicos)
		{

			_agendamentoRepositorio.Create(agendamento);

		}

		public IEnumerable<Agendamento> Get()
		{
			return _agendamentoRepositorio.Get();
		}

		public IEnumerable<Agendamento> GetMenuDataTable(DateTime data)
		{
			return _agendamentoRepositorio.GetMenuList(data);
		}

		public Agendamento Get(int id)
		{
			return _agendamentoRepositorio.Get(id);
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			return _agendamentoRepositorio.GetDatasAgendadas(data);
		}

		public void Delete(int id)
		{
			_agendamentoRepositorio.Delete(id);
		}
	}
}
