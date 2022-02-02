namespace SistemaBarbearia.Controle
{
	class ControleBase
	{
		public delegate void ControleExceptionEventHandler(string mensagem);

		public event ControleExceptionEventHandler ControleExceptionRaised;


		protected virtual void OnControleExceptionRaised(string mensagem)
		{
			ControleExceptionRaised(mensagem);
		}
	}
}
