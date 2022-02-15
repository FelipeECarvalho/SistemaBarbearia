using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

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
				return _context.Agendamentos
				.AsNoTracking()
				.Include(x => x.Cliente.Nome)
				.Where(x => x.Data.Date == data)
				.ToList();
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return null;
		}

		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
		{
			try
			{
				_context.Agendamentos
				  .AsNoTracking()
				  .Select(x => x.Data)
				  .Where(x => x.Date == data.Date);
			}
			catch (SqlException) { OnRepositorioExceptionRaised("Erro ao acessar os dados. Tente novamente."); }

			return null;
		}
	}
}
