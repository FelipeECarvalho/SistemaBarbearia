using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Modelo
{
	[Table("Servico")]
	class Servico
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }

		public override string ToString()
		{
			return $"{Descricao} - R${Valor.ToString("F2")}";
		}
	}
}
