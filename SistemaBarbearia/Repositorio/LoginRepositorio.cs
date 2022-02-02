using Dapper;
using SistemaBarbearia.Modelo;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase<Administrador>
	{
		public Administrador Acessar(string usuario, string senha)
		{
			var query = "SELECT * FROM [Administrador] WHERE [Usuario] = @Usuario AND [Senha] = @Senha";
			var param = new { @Usuario = usuario, @Senha = senha };

			return Database.Connection.QueryFirst<Administrador>(query, param);
		}
	}
}
