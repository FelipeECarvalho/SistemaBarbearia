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
			if (string.IsNullOrEmpty(txbCPF.Text.Trim()) || string.IsNullOrEmpty(txbNome.Text.Trim()) || string.IsNullOrEmpty(txbTelefone.Text.Trim()) || string.IsNullOrEmpty(txbEmail.Text.Trim()))
			{
				MessageBox.Show("Erro ao cadastrar cliente. Verifique os dados", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var cliente = new Cliente() { Nome = txbNome.Text, Cpf = txbCPF.Text, Email = txbEmail.Text.ToLower(), Telefone = txbTelefone.Text };

			_clienteControle.Create(cliente);

			MessageBox.Show("Cliente cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

	}
}
