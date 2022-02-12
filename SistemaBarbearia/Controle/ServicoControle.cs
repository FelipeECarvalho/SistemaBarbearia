using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Collections.Generic;

namespace SistemaBarbearia.Controle
{
	class ServicoControle : ControleBase
	{
		private readonly ServicoRepositorio _servicoRepositorio;
		public ServicoControle() => _servicoRepositorio = new ServicoRepositorio();


		public IEnumerable<Servico> Get()
		{
			return _servicoRepositorio.Get();
		}

		public void Create(Servico servico)
		{
			_servicoRepositorio.Create(servico);
		}
	}
}
