using SistemaBarbearia.Repositorio;
using System;
using System.Threading.Tasks;

namespace SistemaBarbearia.Controle
{
	class LoginControle : ControleBase
	{
		private readonly LoginRepositorio _loginRepositorio;

		public LoginControle() => _loginRepositorio = new LoginRepositorio();

		public async Task LoginAsync(string login, string senha)
		{
			try
			{
				Program.Adm = await _loginRepositorio.AcessarAsync(login, senha)
					?? throw new NullReferenceException();
			}
			catch (NullReferenceException) { OnControleExceptionRaised("Usuário ou senha inválidos", "Login"); }
		}
	}
}
