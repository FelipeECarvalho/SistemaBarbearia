using SistemaBarbearia.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class ServicoRepositorio : RepositorioBase
	{
		public IEnumerable<Servico> Get()
		{
			return context.Servicos.ToList();
		}

		public void Create(Servico servico) 
		{
			context.Servicos.Add(servico);
			context.SaveChanges();
		}
	}
}
