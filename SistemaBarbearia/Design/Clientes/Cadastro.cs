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
		private ClienteControle _clienteControle;

		public frmCadastro()
		{
			InitializeComponent();
			_clienteControle = new ClienteControle();
		}

		private void txbCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			var cliente = new Cliente(txbCPF.Text.Trim(), txbNome.Text.ToLower().Trim(), txbTelefone.Text, txbEmail.Text.Trim());

			_clienteControle.Create(cliente);

			MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

	}
}
