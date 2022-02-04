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
			if (string.IsNullOrEmpty(txbDescricao.Text) || (string.IsNullOrEmpty(txbValor.Text)))
			{
				MessageBox.Show("Não foi possivel cadastrar servico, verifique os dados", "Servico", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var servico = new Servico() { Descricao = txbDescricao.Text, Valor = decimal.Parse(txbValor.Text, CultureInfo.InvariantCulture) };

			_servicoControle.Create(servico);

			MessageBox.Show("Servico cadastrado com sucesso!", "Servico", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.Close();
		}
	}
}
