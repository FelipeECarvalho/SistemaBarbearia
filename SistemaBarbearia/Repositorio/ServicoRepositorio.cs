using Dapper;
using SistemaBarbearia.Modelo;
using System.Collections.Generic;

namespace SistemaBarbearia.Repositorio
{
	class ServicoRepositorio : RepositorioBase<Servico>
	{

		public IEnumerable<Servico> GetByAgendamento(int agendamentoId)
		{
			var query = @"SELECT s.*
						  FROM [Servico] s
						  INNER JOIN
						  [ServicoAgendamento] sa
						  ON s.Id = sa.[IdServico]
						  WHERE sa.[IdAgendamento] = @AgendamentoId";

			var param = new { @AgendamentoId = agendamentoId };

			return Database.Connection.Query<Servico>(query, param);
		}
	}
}
