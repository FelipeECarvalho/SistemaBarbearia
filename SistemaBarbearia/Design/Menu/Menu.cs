using SistemaBarbearia.Controle;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmMenu : Form
	{
		private readonly AgendamentoControle _agendamentoControle;

		public frmMenu()
		{
			InitializeComponent();
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
			lblNome.Text += Program.Adm.Nome;
			var agendamentos = _agendamentoControle.GetMenu(DateTime.Today);

			dgvAgendamentos.Columns.Add("Nome", "Nome");
			dgvAgendamentos.Columns.Add("Data", "Data");
			
			foreach (var agendamento in agendamentos) 
			{
				dgvAgendamentos.Rows.Add(agendamento.Cliente.Nome, agendamento.Data.ToString("g"));
			}
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos().Show();
			this.Hide();
		}
	}
}
