using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendamentos : Form
	{
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

		private void dgvAgendamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				lboServicosEscolhidos.Items.Clear();

				var dgv = dgvAgendamentos.Rows[e.RowIndex];
				txbData.Text = dgv.Cells["DATA"].Value.ToString();

				var agendamento = _agendamentoControle.Get(DateTime.Parse(txbData.Text));
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

		private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				var dataView = _agendamentoControle.GetDataTable().DefaultView;

				dataView.RowFilter = string.Format("NOME LIKE '%@Nome%'", new { @Nome = txbNome.Text});

				dgvAgendamentos.DataSource = dataView.Table;
			}

		}

		private void frmAgendamentos_Load(object sender, EventArgs e)
		{
			dgvAgendamentos.DataSource = _agendamentoControle.GetDataTable();
		}

		private void btnExcluirAgendamento_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txbData.Text))
			{
				MessageBox.Show("Erro ao excluir, selecione um agendamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Tem certeza que deseja excluir o agendamento?", "Exclusao", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					_agendamentoControle.Delete(DateTime.Parse(txbData.Text));

					txbClienteNome.Text = "";
					txbClienteTelefone.Text = "";
					txbData.Text = "";
					txbValor.Text = "";

					lboServicosEscolhidos.Items.Clear();
					dgvAgendamentos.DataSource = null;
					dgvAgendamentos.DataSource = _agendamentoControle.GetDataTable();


					MessageBox.Show("Agendamento excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
