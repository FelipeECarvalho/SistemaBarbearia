using System.Windows.Forms;

namespace SistemaBarbearia.Exception
{
	class ControleException
	{
		public void OnControleExceptionRaised(string mensagem)
		{
			MessageBox.Show(mensagem, "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
