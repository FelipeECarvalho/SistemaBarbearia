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
			_loginControle.Login(txbUsuario.Text, txbSenha.Text, this);
		}

		private void btnSair_Click(object sender, EventArgs e) => this.Close();
	}
}
