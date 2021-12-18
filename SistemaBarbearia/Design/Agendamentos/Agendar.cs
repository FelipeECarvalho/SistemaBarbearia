using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using SistemaBarbearia.Modelo;
using System.Windows.Forms;
using System.Globalization;
using SistemaBarbearia.Controle;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendar : Form
	{
		frmMenu menu;

		AgendamentoControle agendamentocontrole = new AgendamentoControle();
		ServicoControle servicoControle = new ServicoControle();
		ClienteControle clienteControle = new ClienteControle();

		decimal valorTotalAgendamento = 0;
		string cpfCliente;
		Cliente cliente = new Cliente();
		List<Servico> servicos = new List<Servico>();
		DateTime dia = new DateTime();
		bool escolheuHorario = false;


		public frmAgendar()
		{
			InitializeComponent();
		}

		public frmAgendar(frmMenu menu) : this()
		{
			this.menu = menu;
		}

		private void PovoarLista()
		{
			List<Servico> servicos = servicoControle.GetServicos();
			foreach (Servico s in servicos)
			{
				cklServicos.Items.Add(s);
			}
		}


		private void Agendar_Load(object sender, EventArgs e)
		{
			PovoarLista();
		}


		private void lblAgendar_Click(object sender, EventArgs e)
		{

		}

		private void lblInicio_Click(object sender, EventArgs e)
		{
			menu.Show();
			this.Close();
		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente(menu).Show();
			this.Close();
		}

		private void cklServicos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dtpData_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btnAgendar_Click(object sender, EventArgs e)
		{
			if (escolheuHorario)
			{
				if (agendamentocontrole.InserirAgendamento(cliente.Cpf, dia, valorTotalAgendamento, servicos))
				{
					MessageBox.Show("Agendamento cadastrado com sucesso!", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
					menu.Show();
					this.Close();

				}
				else
				{
					MessageBox.Show("Não foi possivel agendar, verifique os dados", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else 
			{
				MessageBox.Show("Não foi possivel agendar, verifique os dados", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frmEscolherCliente escolherCliente = new frmEscolherCliente();

			var result = escolherCliente.ShowDialog();

			if (result == DialogResult.OK)
			{
				cpfCliente = escolherCliente.RetornarCpfCliente;
				cliente = clienteControle.GetCliente(cpfCliente);
				txbCpf.Text = cliente.Cpf;
				txbNome.Text = cliente.Nome;
			}
		}

		private void txbNome_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnGuardarServicos_Click(object sender, EventArgs e)
		{
			servicos.Clear();
			lboServicosEscolhidos.Items.Clear();
			valorTotalAgendamento = 0;
			foreach (Servico s in cklServicos.CheckedItems)
			{
				valorTotalAgendamento += s.Valor;
				lboServicosEscolhidos.Items.Add(s);
				servicos.Add(s);
			}
			lblTotal.Text = "Total R$" + valorTotalAgendamento.ToString("F2");
			cklServicos.Items.Clear();
			PovoarLista();
		}

		private void lblTotal_Click(object sender, EventArgs e)
		{

		}

		private void btnHorario_Click(object sender, EventArgs e)
		{
			frmHorario horario = new frmHorario(DateTime.ParseExact(dtpData.Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
			horario.ShowDialog();
			if (horario.DialogResult == DialogResult.OK)
			{
				dia = horario.RetornoData;
				lblData.Text = dia.ToString("Dia: dd/MM/yyyy");
				lblData.Text += $" Horario: " + dia.ToString("HH:00");
				escolheuHorario = true;
			}
		}

		private void lblData_Click(object sender, EventArgs e)
		{

		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos(menu).Show();
			this.Close();
		}
	}
}
