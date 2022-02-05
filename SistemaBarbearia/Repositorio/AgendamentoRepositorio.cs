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
				var param = new { @IdAgendamento = agendamento.Id, @IdServico = servico.Id };
				Database.Connection.Execute(query, param);
			}
		}

		public IEnumerable<Agendamento> GetWithServicos(DateTime data)
		{
			var query = @"SELECT a.*,
								 s.*
						  FROM [Agendamento] a 
						  INNER JOIN
						  [ServicoAgendamento] sa
						  ON a.Id = sa.IdAgendamento
						  INNER JOIN
						  [Servico] s
						  ON s.Id = sa.IdServico
						  WHERE
						  CAST(a.Data AS DATE) = @Data";

			var param = new { @Data = data.Date };

			var agendamentos = new List<Agendamento>();

			var povoamento = Database.Connection.Query<Agendamento, Servico, Agendamento>(query,
			(agenda, servico) =>
			{
				var age = agendamentos.FirstOrDefault(x => x.Id == agenda.Id);
				if (age == null)
				{
					age = agenda;
					age.Servicos.Add(servico);
					agendamentos.Add(age);
				}
				else
				{
					age.Servicos.Add(servico);
				}
				return agenda;
			}
			, param);
			return agendamentos;
		}

		public IEnumerable<Agendamento> Get(DateTime data) 
		{
			var query = "SELECT * FROM [Agendamento] WHERE CAST([Data] as DATE) = @Data";
			var param = new { @Data = data.Date };

			return Database.Connection.Query<Agendamento>(query, param);
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
