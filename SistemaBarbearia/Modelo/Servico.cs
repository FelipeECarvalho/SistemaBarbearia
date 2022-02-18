using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBarbearia.Modelo
{
	[Table("Servico")]
	public class Servico
	{
		public int Id { get; set; }
		public string Descricao { get; set; }
		public decimal Valor { get; set; }

		public override string ToString()
		{
			return $"{Descricao} - R${Valor:F2}";
		}

		public Servico(string descricao, decimal valor)
		{
			Descricao = descricao;
			Valor = valor;
		}
	}
}
