using SistemaBarbearia.Data;
using SistemaBarbearia.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class ServicoRepositorio : RepositorioBase<Servico>
	{
		public ServicoRepositorio() => _context = new BarbeariaDbContext();
	}
}
