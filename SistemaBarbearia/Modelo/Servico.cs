using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Modelo
{
	[Table("Servico")]
	class Servico
	{
		public int Id { get; }
		public string Descricao { get; }
		public decimal Valor { get; }

		public override string ToString()
		{
			return $"{Descricao} - R${Valor.ToString("F2")}";
		}
	}
}
