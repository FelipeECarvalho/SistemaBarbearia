using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System.Collections.Generic;

namespace SistemaBarbearia.Controle
{
	class ServicoControle : ControleBase
	{
		private readonly ServicoRepositorio _servicoRepositorio;
		public ServicoControle()
		{
			_servicoRepositorio = new ServicoRepositorio();
		}

		public IEnumerable<Servico> Get()
		{
			using (var conexao = new Conexao())
			{
				return _servicoRepositorio.Get();
			}
		}

		public IEnumerable<Servico> GetByAgendamento(int idAgendamento)
		{
			using (var conexao = new Conexao())
			{
				return _servicoRepositorio.GetByAgendamento(idAgendamento);
			}
		}
	}
}
