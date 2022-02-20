using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Collections.Generic;
using System.Globalization;

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

		public bool Create(string desc, string valor)
		{
			try
			{
				if (string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(valor)) throw new NullReferenceException();

				var servico = new Servico(desc, decimal.Parse(valor, CultureInfo.InvariantCulture));
				_servicoRepositorio.Create(servico);

				OnControleSuccessfullyAction("Servico criado com sucesso!", "Servico");
				return true;
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Não foi possível inserir. Verifique os dados", "Servico"); }

			return false;
		}
	}
}
