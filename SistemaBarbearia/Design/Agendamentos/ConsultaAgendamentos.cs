using SistemaBarbearia.Controle;
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
				var dataView = _agendamentoControle.GetDataTable().DefaultView;

				dataView.RowFilter = string.Format("NOME LIKE '%@Nome%'", new { @Nome = txbNome.Text });

				dgvAgendamentos.DataSource = dataView.Table;
			}

		}

		private void frmAgendamentos_Load(object sender, EventArgs e)
		{
			dgvAgendamentos.DataSource = _agendamentoControle.GetDataTable();
		}


		private void btnExcluirAgendamento_Click(object sender, EventArgs e)
		{
			if (_linhaAtual < 0)
			{
				MessageBox.Show("Erro ao excluir, selecione um agendamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("Tem certeza que deseja excluir o agendamento?", "Exclusao", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			_agendamentoControle.Delete((int)dgvAgendamentos.Rows[_linhaAtual].Cells["Id"].Value);

			txbClienteNome.Text = "";
			txbClienteTelefone.Text = "";
			txbData.Text = "";
			txbValor.Text = "";

			lboServicosEscolhidos.Items.Clear();
			dgvAgendamentos.DataSource = null;
			dgvAgendamentos.DataSource = _agendamentoControle.GetDataTable();


			MessageBox.Show("Agendamento excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				lboServicosEscolhidos.Items.Clear();
				_linhaAtual = dgvAgendamentos.CurrentRow.Index;

				var agendamento = _agendamentoControle.Get((int)dgvAgendamentos.Rows[_linhaAtual].Cells["Id"].Value);

				txbData.Text = $"{agendamento.Data.Date} {agendamento.Data.Hour} horas";

				var cliente = _clienteControle.Get(agendamento.IdCliente);

				txbClienteNome.Text = cliente.Nome;
				txbClienteTelefone.Text = cliente.Telefone;

				txbValor.Text = agendamento.ValorTotal.ToString("F2");

				foreach (var servico in agendamento.Servicos)
				{
					lboServicosEscolhidos.Items.Add(servico);
				}
			}

		}
	}
}
