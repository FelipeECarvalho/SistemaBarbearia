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

		public void Create(Agendamento agendamento)
		{
			using (var conexao = new Conexao())
			{
				_agendamentoRepositorio.Create(agendamento);
			}
		}

		public IEnumerable<DateTime> GetDatas(DateTime data)
		{
			using (var conexao = new Conexao())
			{
				return _agendamentoRepositorio.GetDatas(data);
			}
		}

		public DataTable GetTable(string data = null)
		{
			IEnumerable<Agendamento> agendamentos;
			using (var conexao = new Conexao())
			{
				if (data == null)
				{
					agendamentos = _agendamentoRepositorio.Get();
				}
				else 
				{
					agendamentos = _agendamentoRepositorio.GetAll(DateTime.Parse(data));
				}
				return _agendamentoRepositorio.GetDataTable(agendamentos.ToList());
			}
		}

		public Agendamento Get(DateTime data)
		{
			using (var conexao = new Conexao())
			{
				return  _agendamentoRepositorio.Get(data);
			}
		}
	}
}
