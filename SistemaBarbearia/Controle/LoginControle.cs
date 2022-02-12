using Microsoft.Data.SqlClient;
using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;

namespace SistemaBarbearia.Controle
{
	class LoginControle : ControleBase
	{
		private readonly LoginRepositorio _loginRepositorio;

		public LoginControle() => _loginRepositorio = new LoginRepositorio();

		public Administrador Login(string login, string senha)
		{
			return _loginRepositorio.Acessar(login, senha);
		}
	}
}
