using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;

namespace SistemaBarbearia.Controle
{
	class ServicoControle : ControleBase
	{
		private ServicoRepositorio _servicoRepositorio;

		public ServicoControle() 
		{
			_servicoRepositorio = new ServicoRepositorio();
		}

		public IEnumerable<Servico> Get()
		{
			return _servicoRepositorio.Get();
		}

		public bool Create(Servico servico)
		{
			try
			{
				if (string.IsNullOrEmpty(servico.Descricao) || servico.Valor == 0) throw new Exception();
				_servicoRepositorio.Create(servico);

				OnControleSuccessfullyAction("Servico criado com sucesso!", "Servico");
				return true;
			}
			catch (Exception) { OnControleExceptionRaised("Não foi possível inserir. Verifique os dados", "Servico"); }

			return false;
		}
	}
}
