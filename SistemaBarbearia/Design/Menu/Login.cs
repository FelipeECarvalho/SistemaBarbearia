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

		private async void btnEntrar_Click(object sender, EventArgs e)
		{
			await _loginControle.LoginAsync(txbUsuario.Text, txbSenha.Text);

			if (Program.Adm == null) return;

			new frmMenu().Show();
			this.Hide();
		}

		private void btnSair_Click(object sender, EventArgs e) => this.Close();
	}
}
