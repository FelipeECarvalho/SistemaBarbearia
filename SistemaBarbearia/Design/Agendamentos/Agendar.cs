﻿using SistemaBarbearia.Controle;
using SistemaBarbearia.Design.Agendamentos;
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
			_agendamento.Data = dtpData.Value.Date;
			lblData.Text = "Data: " + dtpData.Value.Date.ToString("dd/MM/yyyy");
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
				return;
			}

			_agendamentoControle.Create(_agendamento, _agendamento.Servicos);

			MessageBox.Show("Agendamento cadastrado com sucesso!", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ZerarResumo();
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
			if (cklServicos.CheckedItems.Count == 0)
			{
				MessageBox.Show("Nenhum servico escolhido, verifique os dados", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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

			if (dtpData.Value.Date < DateTime.Now.Date || dtpData.Value == DateTime.MinValue)
			{
				MessageBox.Show("Data inválida, verifique os dados", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var horario = new frmHorario(dtpData.Value);
			horario.ShowDialog();


			if (horario.DialogResult == DialogResult.OK)
			{
				var horarioEscolhido = horario.RetornoHorario;

				_agendamento.Data = new DateTime(dtpData.Value.Year, dtpData.Value.Month, dtpData.Value.Day, horarioEscolhido, 00, 00);

				lblHorario.Text = $"Horário: {_agendamento.Data.Hour.ToString()} horas";
			}
		}

		private void dtpData_ValueChanged(object sender, EventArgs e)
		{
			_agendamento.Data = dtpData.Value.Date;
			lblHorario.Text = "Horário: ";
			lblData.Text = "Data: " + dtpData.Value.Date.ToString("dd/MM/yyyy");

		}

		private void ZerarResumo()
		{
			_agendamento = new Agendamento();
			lblTotal.Text = "Total R$";
			lblHorario.Text = "Horário: ";
			_agendamento.Data = dtpData.Value.Date;
			lblData.Text = "Data: " + dtpData.Value.Date.ToString("dd/MM/yyyy");
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
	}
}
