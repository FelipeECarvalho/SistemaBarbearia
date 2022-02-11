using SistemaBarbearia.Modelo;
using SistemaBarbearia.Repositorio;
using Microsoft.Data.SqlClient;

namespace SistemaBarbearia.Controle
{
	class LoginControle : ControleBase
	{
		private readonly LoginRepositorio _loginRepositorio;

		public LoginControle() => _loginRepositorio = new LoginRepositorio();

		public Administrador Login(string login, string senha)
		{
			try
			{
				using (var conexao = new Conexao())
				{
					return _loginRepositorio.Acessar(login, senha);
				}
			}
			catch (SqlException e) { OnControleExceptionRaised($"Não foi possivel acessar. Verifique a conexão. \n {e.Source}"); }

			return null;
		}
	}
}
