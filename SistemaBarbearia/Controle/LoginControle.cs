using SistemaBarbearia.DAL;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Controle
{
	class LoginControle
	{
		LoginComandos loginComandos = new LoginComandos();


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
