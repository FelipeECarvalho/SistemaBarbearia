using SistemaBarbearia.Controle;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmMenu : Form
	{
		private readonly AgendamentoControle _agendamentoControle;
		private readonly ClienteControle _clienteControle;

		public frmMenu()
		{
			InitializeComponent();
			lblNome.Text += " " + Program.Adm.Nome;
			_agendamentoControle = new AgendamentoControle();
			_clienteControle = new ClienteControle();
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
			dgvAgendamentos.DataSource = _agendamentoControle.GetMenuDataTable(DateTime.Now);
			dgvAgendamentos.Columns["IdCliente"].Visible = false;
			dgvAgendamentos.Columns["ValorTotal"].Visible = false;
			dgvAgendamentos.Columns["Id"].Visible = false;
			dgvAgendamentos.Columns["NomeCliente"].HeaderText = "Nome";
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos().Show();
			this.Hide();
		}
	}
}
