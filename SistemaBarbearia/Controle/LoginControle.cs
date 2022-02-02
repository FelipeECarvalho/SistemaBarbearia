using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;

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
