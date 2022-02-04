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

		public IEnumerable<DateTime> GetDatas(DateTime data)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _agendamentoRepositorio.GetDatas(data);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar as datas. Verifique a conexão. \n {e.Source}"); }

			return null;
		}

		public DataTable GetDataTable(DateTime? data = null)
		{
			IEnumerable<Agendamento> agendamentos;
			try
			{
				using (var conexao = new Conexao())
				{
					if (!data.HasValue)
						agendamentos = _agendamentoRepositorio.Get();
					else
						agendamentos = _agendamentoRepositorio.GetAll(data.Value);

					return _agendamentoRepositorio.GetDataTable(agendamentos.ToList());
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


		public void Delete(int id)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					var agendamento = Get(id);
					_agendamentoRepositorio.Delete(agendamento);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel deletar o agendamento. Verifique a conexão. \n {e.Source}"); }
		}
	}
}
