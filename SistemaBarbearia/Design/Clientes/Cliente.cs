using SistemaBarbearia.Controle;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmCliente : Form
	{
		private readonly ClienteControle _clienteControle;

		public frmCliente()
		{
			InitializeComponent();
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

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos().Show();
			this.Close();
		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			frmCadastro cadastro = new frmCadastro();

			cadastro.ShowDialog();

			if (cadastro.DialogResult == DialogResult.OK)
			{
				dgvClientes.DataSource = null;
				dgvClientes.DataSource = _clienteControle.GetDataTable();
			}
		}

		private void frmCliente_Load(object sender, EventArgs e)
		{
			dgvClientes.DataSource = _clienteControle.GetDataTable();
		}

		private void btnExcluirCliente_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txbCpf.Text))
			{
				//MessageBox.Show("Erro ao excluir, selecione um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("ERRO");
			}
			else
			{
				if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Exclusao", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					var cliente = _clienteControle.Get(txbCpf.Text);
					_clienteControle.Delete(cliente);

					txbNome.Text = "";
					txbCpf.Text = "";
					txbEmail.Text = "";
					txbTelefone.Text = "";

					dgvClientes.DataSource = null;
					dgvClientes.DataSource = _clienteControle.GetDataTable();

					MessageBox.Show("Cliente excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
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
				DataView dv = _clienteControle.GetDataTable().DefaultView;

				dv.RowFilter = string.Format("NOME LIKE '%" + txtBuscaCliente.Text + "%' OR CPF LIKE '%" + txtBuscaCliente.Text + "%'");
				dgvClientes.DataSource = dv.Table;
			}
		}


		private void btnCancelar_Click(object sender, EventArgs e)
		{
			ZerarUpdate();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			var cliente = _clienteControle.Get(txbCpf.Text);
			if (cliente == null)
			{
				MessageBox.Show("Erro ao atualizar, verifique os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				cliente.SetEmail(txbEmail.Text);
				cliente.SetNome(txbNome.Text);
				cliente.SetTelefone(txbTelefone.Text);

				_clienteControle.Update(cliente);

				MessageBox.Show("Cliente atualizado com sucesso!", "Atualizacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ZerarUpdate();

				dgvClientes.DataSource = null;
				dgvClientes.DataSource = _clienteControle.GetDataTable();
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

		private void btnAtualizar_Click(object sender, EventArgs e)
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

	}
}
