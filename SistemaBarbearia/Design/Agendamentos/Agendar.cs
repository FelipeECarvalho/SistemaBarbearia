using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmAgendar : Form
	{

		private AgendamentoControle _agendamentoControle;
		private ServicoControle _servicoControle;
		private ClienteControle _clienteControle;
		private Agendamento _agendamento;


		public frmAgendar()
		{

			_agendamentoControle = new AgendamentoControle();
			_servicoControle = new ServicoControle();
			_clienteControle = new ClienteControle();
			_agendamento = new Agendamento();
			InitializeComponent();
		}

		private void PovoarLista()
		{
			var servicos = _servicoControle.Get();
			foreach (var servico in servicos)
			{
				cklServicos.Items.Add(servico);
			}
		}


		private void Agendar_Load(object sender, EventArgs e)
		{
			PovoarLista();
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
			if ((_agendamento.Data == DateTime.MinValue || _agendamento.Data.Hour == 0) || _agendamento.IdCliente == 0 || _agendamento.ValorTotal == 0)
			{
				MessageBox.Show("Não foi possivel agendar, verifique os dados", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			_agendamentoControle.Create(_agendamento, _agendamento.Servicos);

			MessageBox.Show("Agendamento cadastrado com sucesso!", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			var escolherCliente = new frmEscolherCliente();

			var result = escolherCliente.ShowDialog();

			if (result == DialogResult.OK)
			{
				_agendamento.IdCliente = escolherCliente.RetornarIdCliente;
				var cliente = _clienteControle.Get(_agendamento.IdCliente);

				txbCpf.Text = cliente.Cpf;
				txbNome.Text = cliente.Nome;
			}
		}

		private void btnGuardarServicos_Click(object sender, EventArgs e)
		{
			_agendamento.Servicos.Clear();
			lboServicosEscolhidos.Items.Clear();
			_agendamento.ValorTotal = 0;


			foreach (Servico servico in cklServicos.CheckedItems)
			{
				_agendamento.ValorTotal += servico.Valor;

				lboServicosEscolhidos.Items.Add(servico);

				_agendamento.Servicos.Add(servico);

			}

			lblTotal.Text = "Total R$" + _agendamento.ValorTotal.ToString("F2");

			cklServicos.Items.Clear();

			PovoarLista();
		}

		private void btnHorario_Click(object sender, EventArgs e)
		{

			if (dtpData.Value == null)
				Console.WriteLine("ERRO!");

			var horario = new frmHorario(dtpData.Value);
			horario.ShowDialog();

			if (horario.DialogResult == DialogResult.OK)
			{
				var horarioEscolhido = horario.RetornoHorario;

				_agendamento.Data = new DateTime(dtpData.Value.Year, dtpData.Value.Month, dtpData.Value.Day, horarioEscolhido, 00, 00);

				lblData.Text = "Data: ";
				lblHorario.Text = "Horário: ";
				lblData.Text += _agendamento.Data.ToString("dd/MM/yyyy");
				lblHorario.Text += _agendamento.Data.Hour.ToString() + " horas";
			}
		}
	}
}
