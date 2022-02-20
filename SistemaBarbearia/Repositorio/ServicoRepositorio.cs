using Dapper;
using Microsoft.Data.SqlClient;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Collections.Generic;

namespace SistemaBarbearia.Repositorio
{
	class ServicoRepositorio : RepositorioBase<Servico>
	{
		public ServicoRepositorio() => _context = new BarbeariaDbContext();

		public IEnumerable<Servico> GetByAgendamento(int id)
		{
			try
			{
				var query = @"SELECT s.Descricao, s.Valor FROM Servico s INNER JOIN ServicoAgendamento sa ON s.Id = sa.IdServico INNER JOIN Agendamento a ON sa.IdAgendamento = a.Id WHERE a.Id = @Id";

				var param = new { @Id = id };

				using (var conn = new SqlConnection(BarbeariaDbContext.stringConnection))
				{
					return conn.Query<Servico>(query, param);
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return new List<Servico>();
		}
	}
}
