using System.Windows.Forms;

namespace SistemaBarbearia.Controle
{
	class ControleBase
	{
		protected void OnControleExceptionRaised(string mensagem)
		{
			MessageBox.Show(mensagem, "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
