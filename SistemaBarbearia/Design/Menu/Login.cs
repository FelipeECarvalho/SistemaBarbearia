using SistemaBarbearia.Design;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SistemaBarbearia.Controle;
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
			if (string.IsNullOrEmpty(txbUsuario.Text.Trim()) || string.IsNullOrEmpty(txbSenha.Text.Trim()))
				Console.WriteLine("ERRO");

			var adm =_loginControle.Login(txbUsuario.Text.ToLower(), txbSenha.Text);
			
			if (adm == null)
				Console.WriteLine("ERRO");

			Program.Adm = adm;

			new frmMenu().Show();

			this.Close();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
