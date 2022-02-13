using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmEscolherCliente : Form
	{
		private ClienteControle _clienteControle;
		public Cliente RetornarCliente { get; set; }


		public frmEscolherCliente()
		{
			InitializeComponent();
			_clienteControle = new ClienteControle();
		}

		private void txtBuscaCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				//DataView dv = _clienteControle.GetDataTable().DefaultView;

				//dv.RowFilter = string.Format("Nome LIKE '%" + txtBuscaCliente.Text + "%' OR CPF LIKE '%" + txtBuscaCliente.Text + "'");

				//dgvClientes.DataSource = dv.Table;
			}
		}

		private void EscolherCliente_Load(object sender, EventArgs e)
		{
			dgvClientes.DataSource = _clienteControle.Get();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				RetornarCliente = dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
			}
			this.DialogResult = DialogResult.OK;
			this.Close();

		}
	}
}
