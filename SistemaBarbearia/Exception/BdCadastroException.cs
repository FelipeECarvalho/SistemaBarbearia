using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBarbearia.Exception
{
	class BdCadastroException : ApplicationException
	{
		public BdCadastroException(string message) : base(message) 
		{
		
		}
	}
}
