using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaBarbearia.Controle
{
	class AgendamentoControle : ControleBase
	{
		private readonly AgendamentoRepositorio _agendamentoRepositorio;

		public AgendamentoControle() => _agendamentoRepositorio = new AgendamentoRepositorio();


		public void Create(Agendamento agendamento, List<Servico> servicos)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					_agendamentoRepositorio.Create(agendamento, servicos);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel inserir cadastro, verifique a conexão. \n {e.Source}"); }
		}

		public DataTable GetDataTable()
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _agendamentoRepositorio.GetDataTable(_agendamentoRepositorio.Get().ToList());
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os agendamentos. Verifique a conexão. \n {e.Source}"); }

			return null;
		}

		public DataTable GetMenuDataTable(DateTime data)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _agendamentoRepositorio.GetDataTable(_agendamentoRepositorio.GetMenuList(data).ToList());
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os agendamentos. Verifique a conexão. \n {e.Source}"); }

			return null;
		}

		public Agendamento Get(int id)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _agendamentoRepositorio.GetWithServicos(id);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar o agendamento. Verifique a conexão. \n {e.Source}"); }

			return null;
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _agendamentoRepositorio.GetDatasAgendadas(data);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os agendamentos. Verifique a conexão. \n {e.Source}"); }

			return null;
		}


		public void Delete(int id)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					_agendamentoRepositorio.Delete(id);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel deletar o agendamento. Verifique a conexão. \n {e.Source}"); }
		}
	}
}
