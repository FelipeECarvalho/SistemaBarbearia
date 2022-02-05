using Dapper;
using SistemaBarbearia.Modelo;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase<Administrador>
	{
		public Administrador Acessar(string usuario, string senha)
		{
			var query = "SELECT [Nome] FROM [Administrador] WHERE [Usuario] = @Usuario AND [Senha] = @Senha";
			var param = new { @Usuario = usuario, @Senha = senha };

			return Database.Connection.QueryFirstOrDefault<Administrador>(query, param);
		}
	}
}
