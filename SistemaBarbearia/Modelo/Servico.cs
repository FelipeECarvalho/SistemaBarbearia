using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	[Table("Servico")]
	class Servico
	{
		public int Id { get; }
		public string Descricao { get; }
		public decimal Valor { get; }
	}
}
