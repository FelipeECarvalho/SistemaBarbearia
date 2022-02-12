using SistemaBarbearia.Modelo;
using System.Linq;

namespace SistemaBarbearia.Repositorio
{
	class LoginRepositorio : RepositorioBase
	{
		public Administrador Acessar(string usuario, string senha)
			=> context.Administradores
			.SingleOrDefault(x => x.Usuario == usuario && x.Senha == senha);
	}
}
