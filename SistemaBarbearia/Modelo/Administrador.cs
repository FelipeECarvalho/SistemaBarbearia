using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Modelo
{
	[Table("Administrador")]
	public class Administrador
	{
		public int Id { get; set; }
		public string Usuario { get; set; }
		public string Senha { get; set; }
		public string Nome { get; set; }
	}
}
