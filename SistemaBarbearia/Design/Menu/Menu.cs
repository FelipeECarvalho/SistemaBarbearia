using SistemaBarbearia.DAL;
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
		Administrador administrador;
		AgendamentoControle agendamentoControle = new AgendamentoControle();

		public frmMenu()
		{
			InitializeComponent();
		}

		public frmMenu(Administrador adm) : this()
		{
			administrador = adm;
			lblNome.Text += " " + adm.Nome;
		}

		private void lblNome_Click(object sender, EventArgs e)
		{

		}

		private void lblAgendar_Click(object sender, EventArgs e)
		{
			new frmAgendar(this).Show();
			this.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lblInicio_Click(object sender, EventArgs e)
		{

		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente(this).Show();
			this.Hide();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			dgvAgendamentos.DataSource = agendamentoControle.GetAgendamentoTable(DateTime.Now.ToString());

		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos(this).Show();
			this.Hide();
		}

		private void dgvAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
