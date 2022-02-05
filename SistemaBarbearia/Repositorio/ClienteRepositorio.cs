using Dapper;
using SistemaBarbearia.Modelo;

namespace SistemaBarbearia.Repositorio
{
	class ClienteRepositorio : RepositorioBase<Cliente>
	{
		public Cliente Get(string cpf)
		{
			var query = "SELECT [Id], [Cpf], [Nome], [Telefone], [Email] FROM [Cliente] WHERE [Cpf] = @Cpf";
			var param = new { @Cpf = cpf };

			return Database.Connection.QueryFirst<Cliente>(query, param);
		}

	}
}
