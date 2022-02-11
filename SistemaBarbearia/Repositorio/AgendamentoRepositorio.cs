using Dapper;
using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class AgendamentoRepositorio : RepositorioBase<Agendamento>
	{
		public void Create(Agendamento agendamento, List<Servico> servicos)
		{
			Create(agendamento);

			var query = @"INSERT INTO [ServicoAgendamento](IdAgendamento, IdServico)
							VALUES(
							@IdAgendamento,
							@IdServico
							)";

			foreach (var servico in servicos)
			{
				Database.Connection.Execute(query, new { @IdAgendamento = agendamento.Id, @IdServico = servico.Id });
			}
		}

		public IEnumerable<Agendamento> GetMenuList(DateTime data)
		{
			var query = @"SELECT a.[IdCliente],
								 a.[Data]
						  FROM [Agendamento] a 
						  WHERE
						  CAST(a.Data AS DATE) = @Data";

			var param = new { @Data = data.Date };

			return Database.Connection.Query<Agendamento>(query, param);
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			var query = "SELECT [Data] FROM [Agendamento] WHERE CAST([Data] as DATE) = @Data";
			var param = new { @Data = data.Date };

			return Database.Connection.Query<DateTime>(query, param);
		}

		public Agendamento GetWithServicos(int id)
		{
			var servicoControle = new ServicoControle();
			var agendamento = new Agendamento();

			agendamento = Get(id);
			agendamento.Servicos.AddRange(servicoControle.GetByAgendamento(id).ToList());

			return agendamento;
		}
	}
}
