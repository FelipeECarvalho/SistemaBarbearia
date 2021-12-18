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
		Agendamento agendamento = new Agendamento();
		frmMenu menu;
		AgendamentoControle controle = new AgendamentoControle();

		public frmAgendamentos()
		{
			InitializeComponent();
		}

		public frmAgendamentos(frmMenu menu) : this()
		{
			this.menu = menu;
		}

		private void lblInicio_Click(object sender, EventArgs e)
		{
			menu.Show();
			this.Close();
		}

		private void lblAgendar_Click(object sender, EventArgs e)
		{
			new frmAgendar(menu).Show();
			this.Close();
		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente(menu).Show();
			this.Close();
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{

		}

		private void dgvAgendamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow dgv = dgvAgendamentos.Rows[e.RowIndex];
				txbData.Text = dgv.Cells["DATA"].Value.ToString();

				agendamento = controle.GetAgendamento(DateTime.Parse(txbData.Text));

				txbClienteNome.Text = agendamento.Cliente.Nome;
				txbClienteTelefone.Text = agendamento.Cliente.Telefone;
				txbValor.Text = agendamento.ValorTotal.ToString("F2");
				lboServicosEscolhidos.Items.Clear();

				foreach (Servico s in agendamento.Servicos)
				{
					lboServicosEscolhidos.Items.Add(s);
				}
			}

		}

		private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				DataView dv = controle.GetAgendamentoTable().DefaultView;
				dv.RowFilter = string.Format("NOME LIKE '%" + txbNome.Text + "%'");
				dgvAgendamentos.DataSource = dv.Table;
			}

		}

		private void frmAgendamentos_Load(object sender, EventArgs e)
		{
			dgvAgendamentos.DataSource = controle.GetAgendamentoTable();
		}

		private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvAgendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void txbValor_TextChanged(object sender, EventArgs e)
		{

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
					controle.ExcluirAgendamento(DateTime.Parse(txbData.Text));

					txbClienteNome.Text = "";
					txbClienteTelefone.Text = "";
					txbData.Text = "";
					txbValor.Text = "";
					lboServicosEscolhidos.Items.Clear();
					dgvAgendamentos.DataSource = null;
					dgvAgendamentos.DataSource = controle.GetAgendamentoTable();


					MessageBox.Show("Agendamento excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
