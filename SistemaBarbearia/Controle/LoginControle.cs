using SistemaBarbearia.Design;
using SistemaBarbearia.Repositorio;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class LoginControle : ControleBase
	{
		private readonly LoginRepositorio _loginRepositorio;

		public LoginControle() => _loginRepositorio = new LoginRepositorio();

		public void Login(string login, string senha, Form form)
		{
			try
			{
				var adm = _loginRepositorio.Acessar(login, senha);
				Program.Adm = adm ?? throw new Exception();

				new frmMenu().Show();
				form.Hide();
			}
			catch (Exception) { OnControleExceptionRaised("Usuário ou senha inválidos", "Login"); }
		}
	}
}
