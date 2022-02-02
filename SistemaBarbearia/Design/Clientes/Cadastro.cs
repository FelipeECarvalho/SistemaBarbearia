using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

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
			var cliente = new Cliente() { Cpf = txbCPF.Text.Trim(), Nome = txbNome.Text.ToLower().Trim(), Telefone = txbTelefone.Text, Email = txbEmail.Text.Trim(), Id = 0 };

			_clienteControle.Create(cliente);

			MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

	}
}
