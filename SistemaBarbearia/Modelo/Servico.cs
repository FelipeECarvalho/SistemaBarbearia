using Dapper.Contrib.Extensions;

namespace SistemaBarbearia.Modelo
{
	[Table("Servico")]
	public class Servico
	{
		public int Id { get; set; }
		public string Descricao { get; set; }

		public readonly decimal Valor;

		public override string ToString()
		{
			return $"{Descricao} - R${Valor:F2}";
		}
	}
}
