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
		Thread th;
		Administrador Adm = new Administrador();
		LoginControle controle = new LoginControle();


		public frmLogin()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void txbEmail_TextChanged(object sender, EventArgs e)
		{


		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			Administrador adm = controle.Login(txbUsuario.Text, txbSenha.Text);
			if (string.IsNullOrEmpty(adm.Nome))
			{
				MessageBox.Show("Erro, verifique usuario e senha", "Erro de acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else 
			{
				this.Close();
				Adm = adm;
				th = new Thread(NewForm);
				th.SetApartmentState(ApartmentState.STA);
				th.Start();
			}
		}

		private void NewForm(object obj)
		{
			Application.Run(new frmMenu(Adm));
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txbSenha_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
