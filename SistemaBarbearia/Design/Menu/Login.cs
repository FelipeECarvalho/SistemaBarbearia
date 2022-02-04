using SistemaBarbearia.Controle;
using SistemaBarbearia.Design;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia
{
	public partial class frmLogin : Form
	{
		private readonly LoginControle _loginControle;

		public frmLogin()
		{
			InitializeComponent();
			_loginControle = new LoginControle();
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{

			var adm = _loginControle.Login(txbUsuario.Text.ToLower(), txbSenha.Text);

			if (adm == null)
			{
				MessageBox.Show($"USUÁRIO OU SENHA INVÁLIDOS", "ControleException", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Program.Adm = adm;

			new frmMenu().Show();
			this.Hide();
		}

		private void btnSair_Click(object sender, EventArgs e) => this.Close();
	}
}
