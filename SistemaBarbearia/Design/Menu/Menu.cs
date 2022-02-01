using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaBarbearia.Controle;

namespace SistemaBarbearia.Design
{
	public partial class frmMenu : Form
	{
		private readonly AgendamentoControle _agendamentoControle;

		public frmMenu()
		{
			InitializeComponent();
			lblNome.Text += " " + Program.Adm;
			_agendamentoControle = new AgendamentoControle();
		}

		private void lblAgendar_Click(object sender, EventArgs e)
		{
			new frmAgendar().Show();
			this.Hide();
		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente().Show();
			this.Hide();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			dgvAgendamentos.DataSource = _agendamentoControle.GetDataTable(DateTime.Now.ToString());
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos().Show();
			this.Hide();
		}
	}
}
