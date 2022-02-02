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

		public AgendamentoControle()
		{
			_agendamentoRepositorio = new AgendamentoRepositorio();
		}

		public void Create(Agendamento agendamento, List<Servico> servicos)
		{
			using (var conexao = new Conexao())
			{
				_agendamentoRepositorio.Create(agendamento, servicos);
			}
		}

		public IEnumerable<DateTime> GetDatas(DateTime data)
		{
			using (var conexao = new Conexao())
			{
				return _agendamentoRepositorio.GetDatas(data);
			}
		}

		public DataTable GetDataTable(DateTime? data = null)
		{
			IEnumerable<Agendamento> agendamentos;

			using (var conexao = new Conexao())
			{
				if (!data.HasValue)
					agendamentos = _agendamentoRepositorio.Get();
				else
					agendamentos = _agendamentoRepositorio.GetAll(data.Value);

				return _agendamentoRepositorio.GetDataTable(agendamentos.ToList());
			}
		}

		public Agendamento Get(int id)
		{
			using (var conexao = new Conexao())
			{
				return _agendamentoRepositorio.GetWithServicos(id);
			}
		}
		public void Delete(int id)
		{
			var agendamento = Get(id);
			_agendamentoRepositorio.Delete(agendamento);
		}
	}
}
