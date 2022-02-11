using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Modelo
{
	public class Administrador
	{
		public int Id { get; set; }
		public string Usuario { get; set; }
		private string _senha { get; set; }
		public string Nome { get; set; }
	}
}
