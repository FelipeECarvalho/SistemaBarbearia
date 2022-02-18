using SistemaBarbearia.Controle;
using SistemaBarbearia.Design.Agendamentos;
using SistemaBarbearia.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendar : Form
	{

		private AgendamentoControle _agendamentoControle;
		private ServicoControle _servicoControle;
		private Agendamento _agendamento;


		public frmAgendar()
		{

			_agendamentoControle = new AgendamentoControle();
			_servicoControle = new ServicoControle();
			_agendamento = new Agendamento();
			InitializeComponent();
		}

		private void PovoarLista()
		{
			cklServicos.Items.AddRange(_servicoControle.Get().ToArray());
		}


		private void Agendar_Load(object sender, EventArgs e)
		{
			PovoarLista();
			_agendamento.Data = dtpData.Value.Date;
			lblData.Text = "Data: " + dtpData.Value.ToString("d");
		}

		private void lblAgendamentos_Click(object sender, EventArgs e)
		{
			new frmAgendamentos().Show();
			this.Close();
		}


		private void lblInicio_Click(object sender, EventArgs e)
		{
			new frmMenu().Show();
			this.Close();
		}

		private void lblCliente_Click(object sender, EventArgs e)
		{
			new frmCliente().Show();
			this.Close();
		}

		private void btnAgendar_Click(object sender, EventArgs e)
		{
			_agendamentoControle.Create(_agendamento);
			ZerarResumo();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			var escolherCliente = new frmEscolherCliente();

			if (escolherCliente.ShowDialog() == DialogResult.OK)
			{
				_agendamento.Cliente = escolherCliente.RetornarCliente;

				txbCpf.Text = _agendamento.Cliente.Cpf;
				txbNome.Text = _agendamento.Cliente.Nome;
			}
		}

		private void btnGuardarServicos_Click(object sender, EventArgs e)
		{
			_agendamento.Servicos.Clear();
			lboServicosEscolhidos.Items.Clear();
			_agendamento.ValorTotal = 0;

			foreach (Servico servico in cklServicos.CheckedItems)
			{
				_agendamento.Servicos.Add(servico);
				lboServicosEscolhidos.Items.Add(servico);
				_agendamento.ValorTotal += servico.Valor;
			}

			lblTotal.Text = "Total R$" + _agendamento.ValorTotal.ToString("F2");
			cklServicos.Items.Clear();
			PovoarLista();
		}

		private void btnHorario_Click(object sender, EventArgs e)
		{
			var horario = new frmHorario(dtpData.Value);
			horario.ShowDialog();
			
			if (horario.DialogResult == DialogResult.OK)
			{
				var horarioEscolhido = horario.RetornoHorario;

				_agendamento.Data = new DateTime(dtpData.Value.Year, dtpData.Value.Month, dtpData.Value.Day, horarioEscolhido, 00, 00);

				lblHorario.Text = $"Horário: {_agendamento.Data.Hour} horas";
			}
		}

		private void dtpData_ValueChanged(object sender, EventArgs e)
		{
			ZerarHorario();
			lblData.Text = "Data: " + dtpData.Value.Date.ToString("d");
		}

		private void ZerarResumo()
		{
			_agendamento = new Agendamento();
			lblTotal.Text = "Total R$";
			ZerarHorario();
			lblData.Text = "Data: " + dtpData.Value.Date.ToString("d");
			txbCpf.Text = "";
			txbNome.Text = "";
			lboServicosEscolhidos.Items.Clear();
		}

		private void lblCadServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var servico = new frmServico();
			servico.ShowDialog();
			if (servico.DialogResult == DialogResult.OK)
			{
				cklServicos.Items.Clear();
				PovoarLista();
			}

		}

		private void ZerarHorario()
		{
			lblHorario.Text = "Horário: ";
			_agendamento.Data = dtpData.Value.Date;
		}
	}
}
