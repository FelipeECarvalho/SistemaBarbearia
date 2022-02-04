using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaBarbearia.Controle
{
	class ServicoControle : ControleBase
	{
		private readonly ServicoRepositorio _servicoRepositorio;
		public ServicoControle()
		{
			_servicoRepositorio = new ServicoRepositorio();
		}

		public IEnumerable<Servico> Get()
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _servicoRepositorio.Get();
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os serviços. Verifique a conexão. {e.Source}"); }

			return null;
		}

		public IEnumerable<Servico> GetByAgendamento(int idAgendamento)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _servicoRepositorio.GetByAgendamento(idAgendamento);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os serviços do agendamento. Verifique a conexão. {e.Source}"); }

			return null;
		}

		public void Create(Servico servico)
		{
			try
			{
				using (var conexao = new Conexao())
				{

					_servicoRepositorio.Create(servico);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar os serviços do agendamento. Verifique a conexão. {e.Source}"); }
		}
	}
}
