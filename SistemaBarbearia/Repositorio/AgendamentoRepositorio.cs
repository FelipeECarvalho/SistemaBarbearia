using Dapper;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

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

			var param = new { @IdAgendamento = agendamento.Id, servicos};
			Database.Connection.Execute(query, param);
		}


		public IEnumerable<DateTime> GetDatas(DateTime data)
		{
			var query = "SELECT [Data] FROM [Agendamento] WHERE CAST([Data] as DATE) = @Data";
			var param = new { @Data = data.Date};

			return Database.Connection.Query<DateTime>(query, param);
		}


		public Agendamento Get(DateTime data)
		{
			var query = @"SELECT a.*, s.* FROM [Agendamento] a 
						  INNER JOIN [ServicoAgendamento] sa
						  ON a.Id = sa.IdAgendamento
						  INNER JOIN [Servico] s
						  ON s.Id = sa.IdServico
						  WHERE a.Data = @Data";

			var param = new { @Data = data };
			var agendamento = new Agendamento();

			var agendamentos = Database.Connection.Query<Agendamento, Servico, Agendamento>(query,
			(agenda, servico) => 
			{
				if (agendamento == null)
					agendamento = agenda;	

				agendamento.Servicos.Add(servico);

				return agenda;
			}
			);
			return agendamento;
		}

		public IEnumerable<Agendamento> GetAll(DateTime data)
		{
			var query = @"SELECT a.*, s.* FROM [Agendamento] a 
						  INNER JOIN [ServicoAgendamento] sa
						  ON a.Id = sa.IdAgendamento
						  INNER JOIN [Servico] s
						  ON s.Id = sa.IdServico
						  WHERE CAST(a.Data AS DATE) = @Data";

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
			);
			return agendamentos;
		}
	}
}
