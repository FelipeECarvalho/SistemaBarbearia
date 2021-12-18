using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Modelo
{
	class Servico
	{
		public int Id { get; }
		public string Descricao { get; }
		public decimal Valor { get; }

		public Servico() 
		{
		}

		public Servico(int id, string descricao, decimal valor)
		{
			Id = id;
			Descricao = descricao;
			Valor = valor;
		}

		public override string ToString()
		{
			return $"{Descricao} - R${Valor:F2}";
		}
	}
}
