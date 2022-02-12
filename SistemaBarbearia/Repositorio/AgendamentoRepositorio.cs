using Microsoft.EntityFrameworkCore;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class AgendamentoRepositorio : RepositorioBase
	{
		public void Create(Agendamento agendamento)
		{
			context.Agendamentos.Add(agendamento);
			context.SaveChanges();
		}

		public void Delete(int id) 
		{
			var agendamento = context.Agendamentos.FirstOrDefault(x => x.Id == id);
			context.Remove(agendamento);
			context.SaveChanges();
		}

		public IEnumerable<Agendamento> GetMenuList(DateTime data)
			=> context.Agendamentos
			.Include(x => x.Cliente)
			.Where(x => x.Data.Date == data.Date);


		public IEnumerable<DateTime> GetDatasAgendadas(DateTime data)
			=> context.Agendamentos
			.Select(x => x.Data)
			.Where(x => x.Date == data.Date);


		public Agendamento Get(int id)
			=> context.Agendamentos
			.Include(x => x.Servicos)
			.FirstOrDefault(x => x.Id == id);

		public IEnumerable<Agendamento> Get()
			=> context.Agendamentos;
	}
}
