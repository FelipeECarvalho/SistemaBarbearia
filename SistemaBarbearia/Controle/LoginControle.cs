using SistemaBarbearia.Exception;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using System;
using System.Data.SqlClient;

namespace SistemaBarbearia.Controle
{
	class LoginControle : ControleBase
	{
		private readonly LoginRepositorio _loginRepositorio;

		public LoginControle()
		{
			_loginRepositorio = new LoginRepositorio();
		}

		public Administrador Login(string login, string senha)
		{
			using (var conexao = new Conexao())
			{
				return _loginRepositorio.Acessar(login, senha);
			}
		}
	}
}
