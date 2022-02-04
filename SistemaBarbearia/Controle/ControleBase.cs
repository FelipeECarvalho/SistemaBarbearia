using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class ControleBase
	{
		protected virtual void OnControleExceptionRaised(string mensagem)
		{
			MessageBox.Show(mensagem, "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
