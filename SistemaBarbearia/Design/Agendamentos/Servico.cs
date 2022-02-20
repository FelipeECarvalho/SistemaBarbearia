using SistemaBarbearia.Controle;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design.Agendamentos
{
	public partial class frmServico : Form
	{
		private ServicoControle _servicoControle;
		public frmServico()
		{
			InitializeComponent();
			_servicoControle = new ServicoControle();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			if (!_servicoControle.Create(txbDescricao.Text, txbValor.Text))
				return;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		private void frmServico_Load(object sender, EventArgs e)
		{
			txbValor.MaxLength = 6;
		}
	}
}
