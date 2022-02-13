using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendamentos : Form
	{
		private int _linhaAtual = -1;
		private AgendamentoControle _agendamentoControle;
		private ClienteControle _clienteControle;

		public frmAgendamentos()
		{
			InitializeComponent();
			_agendamentoControle = new AgendamentoControle();
			_clienteControle = new ClienteControle();
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
			}

		}

		private void frmAgendamentos_Load(object sender, EventArgs e)
		{
			ZerarTable();

		}


		private void btnExcluirAgendamento_Click(object sender, EventArgs e)
		{
			_agendamentoControle.Delete((int)dgvAgendamentos.Rows[_linhaAtual].Cells["Id"].Value);

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
				_linhaAtual = dgvAgendamentos.CurrentRow.Index;

				var agendamento = dgvAgendamentos.SelectedRows[0].DataBoundItem as Agendamento;

				var cliente = _clienteControle.Get(agendamento.IdCliente);

				txbData.Text = $"{agendamento.Data}";
				txbClienteNome.Text = cliente.Nome;
				txbClienteTelefone.Text = cliente.Telefone;
				txbValor.Text = agendamento.ValorTotal.ToString("F2");

				foreach (var servico in agendamento.Servicos)
				{
					lboServicosEscolhidos.Items.Add(servico.Descricao);
				}
			}

		}
		private void ZerarTable()
		{
			dgvAgendamentos.DataSource = null;
			dgvAgendamentos.DataSource = _agendamentoControle.Get();
		}
	}
}
