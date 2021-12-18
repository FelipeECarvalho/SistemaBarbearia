using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaBarbearia.Controle;

namespace SistemaBarbearia.Design
{
	public partial class frmCadastro : Form
	{
		ClienteControle controle = new ClienteControle();

		public frmCadastro()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void txbCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			txbTelefone.Text = txbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

			txbCPF.Text = txbCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");

			controle.Cadastrar(txbCPF.Text.Trim(), txbNome.Text.Trim(), txbTelefone.Text.Trim(), txbEmail.Text.Trim());

			MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}


		private void txbEmail_TextChanged(object sender, EventArgs e)
		{

		}

		private void txbNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmCadastro_Load(object sender, EventArgs e)
		{

		}

		private void txbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
