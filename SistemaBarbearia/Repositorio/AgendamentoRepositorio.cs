using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Repositorio
{
	class AgendamentoRepositorio : RepositorioBase<Agendamento>
	{
		public AgendamentoRepositorio() 
		{
			_context = new BarbeariaDbContext();
		}

		public IEnumerable<Agendamento> GetMenuList(DateTime data)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Agendamentos
						.AsNoTracking()
						.Include(x => x.Cliente)
						.Where(x => x.Data.Date == data)
						.ToList();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return new List<Agendamento>();
		}

		public IEnumerable<Agendamento> GetWithClientes()
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Agendamentos
						.Include(x => x.Cliente)
						.ToList();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return new List<Agendamento>();
		}

		public void CreateWithServicos(Agendamento agendamento) 
		{
			try
			{
				var insert = @"INSERT INTO Agendamento VALUES (@IdCliente, @Data, @ValorTotal);SELECT @@IDENTITY";
				var query = @"INSERT INTO ServicoAgendamento VALUES (@IdAgendamento, @IdServico)";

				using (var connection = new SqlConnection(BarbeariaDbContext.stringConnection))
				{
					var id = connection.ExecuteScalar(insert, new { @IdCliente = agendamento.Cliente.Id, @Data = agendamento.Data, @ValorTotal = agendamento.ValorTotal });

					foreach (var servico in agendamento.Servicos)
					{
						connection.Execute(query, new { @IdAgendamento = id, @IdServico = servico.Id });
					}
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

		}


		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			try
			{
				using (_context = new BarbeariaDbContext())
				{
					return _context.Agendamentos
					  .AsNoTracking()
					  .Select(x => x.Data)
					  .Where(x => x.Date == data.Date)
					  .ToList();
				}
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return new List<DateTime>();
		}
	}
}
