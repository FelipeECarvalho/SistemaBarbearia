﻿using SistemaBarbearia.Controle;
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
	public partial class frmEscolherCliente : Form
	{
		private	ClienteControle _clienteControle;
		public string RetornarCpfCliente { get; set; }


		public frmEscolherCliente()
		{
			InitializeComponent();
			_clienteControle = new ClienteControle();
		}

		private void txtBuscaCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				DataView dv = _clienteControle.GetDataTable().DefaultView;

				dv.RowFilter = string.Format("Nome LIKE '%@Busca%' OR CPF LIKE '%@Busca%'", new { @Busca = txtBuscaCliente.Text });

				dgvClientes.DataSource = dv.Table;
			}
		}

		private void EscolherCliente_Load(object sender, EventArgs e)
		{
			dgvClientes.DataSource = _clienteControle.GetDataTable();
			dgvClientes.AutoGenerateColumns = true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow dataGrid = dgvClientes.Rows[e.RowIndex];
				RetornarCpfCliente = dataGrid.Cells["CPF"].Value.ToString();
			}
			this.DialogResult = DialogResult.OK;
			this.Close();

		}
	}
}
