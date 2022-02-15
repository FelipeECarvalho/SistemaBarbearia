using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class ControleBase
	{
		protected void OnControleExceptionRaised(string mensagem, string form)
		{
			MessageBox.Show(mensagem, $"{form}Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		protected void OnControleSuccessfullyAction(string mensagem, string form)
		{
			MessageBox.Show(mensagem, form, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
