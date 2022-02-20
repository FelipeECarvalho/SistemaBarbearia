using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmCliente : Form
	{
		private readonly ClienteControle _clienteControle;
		private Cliente _clienteEscolhido;

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
			var cadastroCLiente = new frmCadastro();
			cadastroCLiente.ShowDialog();

			if (cadastroCLiente.DialogResult == DialogResult.OK)
				GetDataTable();
		}

		private void frmCliente_Load(object sender, EventArgs e)
		{
			GetDataTable();
		}

		private void btnExcluirCliente_Click(object sender, EventArgs e)
		{
			_clienteControle.Delete(_clienteEscolhido);
			ZerarUpdate();
			GetDataTable();
		}

		private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				_clienteEscolhido = dgvClientes.SelectedRows[0].DataBoundItem as Cliente;

				txbCpf.Text = _clienteEscolhido.Cpf;
				txbNome.Text = _clienteEscolhido.Nome;
				txbTelefone.Text = _clienteEscolhido.Telefone;
				txbEmail.Text = _clienteEscolhido.Email;
			}
		}

		private void txtBuscaCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				if (string.IsNullOrEmpty(txtBuscaCliente.Text))
				{
					GetDataTable();
					return;
				}

				var clientes = _clienteControle.FindClientes(txtBuscaCliente.Text);
				dgvClientes.DataSource = clientes;
			}
		}


		private void btnCancelar_Click(object sender, EventArgs e)
		{
			ZerarUpdate();
			GetDataTable();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			_clienteControle.Update(_clienteEscolhido);
			GetDataTable();
			ZerarUpdate();
		}

		private void ZerarUpdate()
		{
			btnOk.Visible = false;
			btnCancelar.Visible = false;
			txbNome.BorderStyle = BorderStyle.Fixed3D;
			txbEmail.BorderStyle = BorderStyle.Fixed3D;
			txbTelefone.BorderStyle = BorderStyle.Fixed3D;
			txbCpf.BorderStyle = BorderStyle.Fixed3D;
			txbCpf.ReadOnly = true;
			txbNome.ReadOnly = true;
			txbTelefone.ReadOnly = true;
			txbEmail.ReadOnly = true;
			ZerarLabels();
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			btnOk.Visible = true;
			btnCancelar.Visible = true;
			txbNome.BorderStyle = BorderStyle.FixedSingle;
			txbEmail.BorderStyle = BorderStyle.FixedSingle;
			txbTelefone.BorderStyle = BorderStyle.FixedSingle;
			txbCpf.BorderStyle = BorderStyle.FixedSingle;
			txbCpf.ReadOnly = false;
			txbNome.ReadOnly = false;
			txbTelefone.ReadOnly = false;
			txbEmail.ReadOnly = false;
		}

		public void GetDataTable()
		{
			dgvClientes.DataSource = null;
			dgvClientes.DataSource = _clienteControle.Get();
			dgvClientes.Columns["Id"].Visible = false;
		}

		public void ZerarLabels()
		{
			txbNome.Text = "";
			txbCpf.Text = "";
			txbTelefone.Text = "";
			txbEmail.Text = "";
			_clienteEscolhido = new Cliente();
		}

		private void txbNome_TextChanged(object sender, EventArgs e)
		{
			_clienteEscolhido.Nome = txbNome.Text;
		}

		private void txbEmail_TextChanged(object sender, EventArgs e)
		{
			_clienteEscolhido.Email = txbEmail.Text;
		}

		private void txbTelefone_TextChanged(object sender, EventArgs e)
		{
			_clienteEscolhido.Telefone = txbTelefone.Text;
		}

		private void txbCpf_TextChanged(object sender, EventArgs e)
		{
			_clienteEscolhido.Cpf = txbCpf.Text;
		}
	}
}
