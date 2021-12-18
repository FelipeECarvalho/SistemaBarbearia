using SistemaBarbearia.Controle;
using SistemaBarbearia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SistemaBarbearia.Design
{
	public partial class frmHorario : Form
	{
		AgendamentoControle controle = new AgendamentoControle();
		private DateTime _dia { get; set; }
		public DateTime RetornoData { get; set; }


		public frmHorario()
		{
			InitializeComponent();
		}

		public frmHorario(DateTime dia) : this()
		{
			_dia = dia;
		}

		private void frmHorario_Load(object sender, EventArgs e)
		{
			List<DateTime> horariosOcupados = controle.GetDatas(_dia);
			List<Button> buttons = new List<Button>
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
			foreach (Button btn in buttons) 
			{
				string[] horaMin = btn.Text.Split(":");
				DateTime h = new DateTime(01, 01, 01, int.Parse(horaMin[0]), 00, 00);

				foreach (DateTime horario in horariosOcupados)

				{
					if (h.Hour == horario.Hour)
					{
						btn.BackColor = Color.Silver;
						btn.Enabled = false;
					}
				}
			}
		}

		private void GeraData(Button button)
		{
			string[] horaMin = button.Text.Split(":");
			DateTime h = new DateTime(01, 01, 01, int.Parse(horaMin[0]), 00, 00);

			RetornoData = new DateTime(_dia.Year, _dia.Month, _dia.Day, h.Hour, 00, 00);
			this.DialogResult = DialogResult.OK;


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
