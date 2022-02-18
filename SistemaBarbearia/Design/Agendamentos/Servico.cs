using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Globalization;
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
			var servico = new Servico(txbDescricao.Text, txbValor.Text);
			if (!_servicoControle.Create(servico))
				return;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
