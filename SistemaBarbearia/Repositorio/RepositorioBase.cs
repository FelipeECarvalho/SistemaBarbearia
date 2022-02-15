using SistemaBarbearia.Data;
using System.Windows.Forms;

namespace SistemaBarbearia.Repositorio
{
	class RepositorioBase
	{
		protected readonly BarbeariaDbContext context = new BarbeariaDbContext();

		protected void OnRepositorioExceptionRaised(string mensagem)
		{
			MessageBox.Show(mensagem, "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
