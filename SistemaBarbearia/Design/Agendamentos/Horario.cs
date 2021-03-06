using SistemaBarbearia.Controle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmHorario : Form
	{
		private AgendamentoControle _agendamentoControle;
		public int RetornoHorario { get; set; }

		private DateTime _dataEscolhida;


		public frmHorario(DateTime data)
		{
			InitializeComponent();
			_agendamentoControle = new AgendamentoControle();
			_dataEscolhida = data;
		}


		private void frmHorario_Load(object sender, EventArgs e)
		{
			var agendamentosDoDia = _agendamentoControle.GetDatasAgendadas(_dataEscolhida);


			var diaAtual = DateTime.Now.Date;
			var horaAtual = DateTime.Now.Hour;

			var buttons = new List<Button>
			{
				btn1,
				btn2,
				btn3,
				btn4,
				btn5,
				btn6,
				btn7,
				btn8,
				btn9
			};

			foreach (var button in buttons)
			{
				var horaBotao = int.Parse(button.Text.Substring(0, 2));

				if (_dataEscolhida.Date < diaAtual || (horaBotao <= horaAtual && _dataEscolhida.Date == diaAtual))
				{
					button.BackColor = Color.Silver;
					button.Enabled = false;
				}
			}

			foreach (var button in buttons)
			{
				var horaBotao = int.Parse(button.Text.Substring(0, 2));
				if (!(button.BackColor == Color.Silver))
				{
					foreach (var horario in agendamentosDoDia)
					{
						if (horario.Hour == horaBotao)
						{
							button.BackColor = Color.Silver;
							button.Enabled = false;
						}
					}
				}
			}

		}

		private void GeraData(Button button)
		{
			int horaMin = int.Parse(button.Text.Substring(0, 2));
			RetornoHorario = horaMin;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			GeraData(btn1);
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			GeraData(btn2);
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			GeraData(btn3);
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			GeraData(btn4);
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			GeraData(btn5);
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			GeraData(btn6);
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			GeraData(btn7);
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			GeraData(btn8);
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			GeraData(btn9);
		}
	}
}
