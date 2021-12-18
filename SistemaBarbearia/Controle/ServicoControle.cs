using SistemaBarbearia.DAL;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Controle
{
	class ServicoControle
	{
		ServicoComandos servicoComandos = new ServicoComandos();

		public ServicoControle()
		{
		}

		public List<Servico> GetServicos()
		{
			return servicoComandos.GetAllServicos();
		}
	}
}
