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
	public partial class frmCliente : Form
	{
		frmMenu menu;
		ClienteControle controle = new ClienteControle();

		public frmCliente()
		{
			InitializeComponent();
		}

		public frmCliente(frmMenu menu) : this()
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

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			frmCadastro cadastro = new frmCadastro();
			cadastro.ShowDialog();
			if (cadastro.DialogResult == DialogResult.OK)
			{
				dgvClientes.DataSource = null;
				dgvClientes.DataSource = controle.GetClienteTable();
			}
		}

		private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void frmCliente_Load(object sender, EventArgs e)
		{
			dgvClientes.DataSource = controle.GetClienteTable();
		}

		private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnExcluirCliente_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txbCpf.Text))
			{
				MessageBox.Show("Erro ao excluir, selecione um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Exclusao", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					controle.ExcluirCliente(txbCpf.Text);

					txbNome.Text = "";
					txbCpf.Text = "";
					txbEmail.Text = "";
					txbTelefone.Text = "";

					dgvClientes.DataSource = null;
					dgvClientes.DataSource = controle.GetClienteTable();

					MessageBox.Show("Cliente excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void txbNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow dgv = dgvClientes.Rows[e.RowIndex];

				txbCpf.Text = dgv.Cells["CPF"].Value.ToString();
				txbNome.Text = dgv.Cells["NOME"].Value.ToString();
				txbTelefone.Text = dgv.Cells["TELEFONE"].Value.ToString();
				txbEmail.Text = dgv.Cells["EMAIL"].Value.ToString();
			}
		}

		private void txtBuscaCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				DataView dv = controle.GetClienteTable().DefaultView;
				dv.RowFilter = string.Format("NOME LIKE '%" + txtBuscaCliente.Text + "%' OR CPF LIKE '%" + txtBuscaCliente.Text + "%'");
				dgvClientes.DataSource = dv.Table;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			btnOk.Visible = true;
			btnCancelar.Visible = true;
			txbNome.BorderStyle = BorderStyle.FixedSingle;
			txbEmail.BorderStyle = BorderStyle.FixedSingle;
			txbTelefone.BorderStyle = BorderStyle.FixedSingle;
			txbNome.ReadOnly = false;
			txbTelefone.ReadOnly = false;
			txbEmail.ReadOnly = false;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			ZerarUpdate();

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (controle.UpdateCliente(txbCpf.Text, txbNome.Text, txbTelefone.Text, txbEmail.Text))
			{
				MessageBox.Show("Cliente atualizado com sucesso!", "Atualizacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ZerarUpdate();

				dgvClientes.DataSource = null;
				dgvClientes.DataSource = controle.GetClienteTable();

			}
			else
			{
				MessageBox.Show("Erro ao atualizar, verifique os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ZerarUpdate()
		{
			btnOk.Visible = false;
			btnCancelar.Visible = false;
			txbNome.BorderStyle = BorderStyle.Fixed3D;
			txbEmail.BorderStyle = BorderStyle.Fixed3D;
			txbTelefone.BorderStyle = BorderStyle.Fixed3D;
			txbNome.ReadOnly = true;
			txbTelefone.ReadOnly = true;
			txbEmail.ReadOnly = true;
			txbNome.Text = "";
			txbCpf.Text = "";
			txbTelefone.Text = "";
			txbEmail.Text = "";
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos(menu).Show();
			this.Close();
		}
	}
}
