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
			var cliente = new Cliente(txbCPF.Text, txbNome.Text, txbTelefone.Text, txbEmail.Text);

			if (!_clienteControle.Create(cliente))
				return;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

	}
}
