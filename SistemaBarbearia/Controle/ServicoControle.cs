using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Collections.Generic;

namespace SistemaBarbearia.Controle
{
	class ServicoControle : ControleBase
	{
		private readonly RepositorioBase<Servico> _repositorio;
		public ServicoControle()
		{
			_repositorio = new RepositorioBase<Servico>();
		}

		public IEnumerable<Servico> Get()
		{
			using (var conexao = new Conexao())
			{
				return _repositorio.Get();
			}
		}
	}
}
