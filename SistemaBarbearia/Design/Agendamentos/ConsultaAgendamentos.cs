using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendamentos : Form
	{
		private Agendamento _agendamentoEscolhido;
		private AgendamentoControle _agendamentoControle;

		public frmAgendamentos()
		{
			InitializeComponent();
			_agendamentoControle = new AgendamentoControle();
		}


		private void lblInicio_Click(object sender, EventArgs e)
		{
			new frmMenu().Show();
			this.Close();
		}

		private void lblAgendar_Click(object sender, EventArgs e)
		{
			new frmAgendar().Show();
			this.Close();
		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente().Show();
			this.Close();
		}

		private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				if (string.IsNullOrEmpty(txbNome.Text))
				{
					ZerarTable();
					return;
				}

				dgvAgendamentos.DataSource = _agendamentoControle.GetFull(txbNome.Text);
			}

		}

		private void frmAgendamentos_Load(object sender, EventArgs e)
		{
			ZerarTable();
		}


		private void btnExcluirAgendamento_Click(object sender, EventArgs e)
		{
			_agendamentoControle.Delete(_agendamentoEscolhido);
			_agendamentoEscolhido = null;

			txbClienteNome.Text = "";
			txbClienteTelefone.Text = "";
			txbData.Text = "";
			txbValor.Text = "";


			lboServicosEscolhidos.Items.Clear();
			ZerarTable();
		}

		private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				lboServicosEscolhidos.Items.Clear();

				_agendamentoEscolhido = dgvAgendamentos.SelectedRows[0].DataBoundItem as Agendamento;

				txbData.Text = _agendamentoEscolhido.Data.ToString("g");
				txbClienteNome.Text = _agendamentoEscolhido.Cliente.Nome;
				txbClienteTelefone.Text = _agendamentoEscolhido.Cliente.Telefone;
				txbValor.Text = _agendamentoEscolhido.ValorTotal.ToString("F2");

				lboServicosEscolhidos.Items.AddRange(_agendamentoEscolhido.Servicos.ToArray());
			}

		}
		private void ZerarTable()
		{
			dgvAgendamentos.DataSource = _agendamentoControle.GetWithClientes();
			dgvAgendamentos.Columns["Id"].Visible = false;
			dgvAgendamentos.Columns["Cliente"].Visible = false;
			dgvAgendamentos.Columns["IdCliente"].Visible = false;
			dgvAgendamentos.Columns["NomeCliente"].HeaderText = "Nome";
		}
	}
}
