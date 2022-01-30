using SistemaBarbearia.DAL;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Controle
{
	class LoginControle
	{
		LoginRepositorio loginComandos = new LoginRepositorio();


		public LoginControle()
		{
		}

		public Administrador Login(string login, string senha)
		{
			Administrador adm = loginComandos.AcessoAdm(login, senha);
			return adm;
		}
	}
}
