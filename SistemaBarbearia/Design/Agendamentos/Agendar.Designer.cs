
namespace SistemaBarbearia.Design
{
	partial class frmAgendar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblInicio = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblAgendar = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.txbCpf = new System.Windows.Forms.TextBox();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cklServicos = new System.Windows.Forms.CheckedListBox();
			this.btnAgendar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnGuardarServicos = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lboServicosEscolhidos = new System.Windows.Forms.ListBox();
			this.btnHorario = new System.Windows.Forms.Button();
			this.lblData = new System.Windows.Forms.Label();
			this.lblAgendamentos = new System.Windows.Forms.Label();
			this.lblHorario = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInicio
			// 
			this.lblInicio.AutoSize = true;
			this.lblInicio.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblInicio.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInicio.Location = new System.Drawing.Point(136, 28);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(53, 20);
			this.lblInicio.TabIndex = 9;
			this.lblInicio.Text = "Inicio";
			this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
			this.pictureBox1.Image = global::SistemaBarbearia.Properties.Resources.scissors_5550322_1280;
			this.pictureBox1.Location = new System.Drawing.Point(13, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// lblAgendar
			// 
			this.lblAgendar.AutoSize = true;
			this.lblAgendar.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblAgendar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgendar.Location = new System.Drawing.Point(219, 28);
			this.lblAgendar.Name = "lblAgendar";
			this.lblAgendar.Size = new System.Drawing.Size(75, 20);
			this.lblAgendar.TabIndex = 7;
			this.lblAgendar.Text = "Agendar";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(-1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(794, 65);
			this.label2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(596, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Agendamento";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblCliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCliente.Location = new System.Drawing.Point(321, 28);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(63, 20);
			this.lblCliente.TabIndex = 15;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
			// 
			// txbCpf
			// 
			this.txbCpf.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbCpf.Location = new System.Drawing.Point(78, 170);
			this.txbCpf.Name = "txbCpf";
			this.txbCpf.ReadOnly = true;
			this.txbCpf.Size = new System.Drawing.Size(172, 25);
			this.txbCpf.TabIndex = 25;
			// 
			// txbNome
			// 
			this.txbNome.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbNome.Location = new System.Drawing.Point(78, 117);
			this.txbNome.Name = "txbNome";
			this.txbNome.ReadOnly = true;
			this.txbNome.Size = new System.Drawing.Size(244, 25);
			this.txbNome.TabIndex = 24;
			// 
			// dtpData
			// 
			this.dtpData.CustomFormat = "";
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpData.Location = new System.Drawing.Point(82, 274);
			this.dtpData.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
			this.dtpData.MinDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(107, 23);
			this.dtpData.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(121, 234);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Escolha o dia e horário";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(125, 330);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 16);
			this.label5.TabIndex = 28;
			this.label5.Text = "Escolha os servicos";
			// 
			// cklServicos
			// 
			this.cklServicos.BackColor = System.Drawing.SystemColors.Control;
			this.cklServicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cklServicos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cklServicos.FormattingEnabled = true;
			this.cklServicos.Location = new System.Drawing.Point(62, 382);
			this.cklServicos.Name = "cklServicos";
			this.cklServicos.Size = new System.Drawing.Size(192, 100);
			this.cklServicos.TabIndex = 29;
			// 
			// btnAgendar
			// 
			this.btnAgendar.BackColor = System.Drawing.Color.Lime;
			this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgendar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAgendar.Location = new System.Drawing.Point(651, 449);
			this.btnAgendar.Name = "btnAgendar";
			this.btnAgendar.Size = new System.Drawing.Size(128, 56);
			this.btnAgendar.TabIndex = 33;
			this.btnAgendar.Text = "Agendar";
			this.btnAgendar.UseVisualStyleBackColor = false;
			this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(121, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 16);
			this.label4.TabIndex = 34;
			this.label4.Text = "Escolha o cliente";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SistemaBarbearia.Properties.Resources.magnifying_glass_1293982_1280;
			this.pictureBox2.Location = new System.Drawing.Point(328, 117);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 36;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnGuardarServicos
			// 
			this.btnGuardarServicos.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnGuardarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarServicos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnGuardarServicos.Location = new System.Drawing.Point(271, 455);
			this.btnGuardarServicos.Name = "btnGuardarServicos";
			this.btnGuardarServicos.Size = new System.Drawing.Size(87, 27);
			this.btnGuardarServicos.TabIndex = 31;
			this.btnGuardarServicos.Text = "Adicionar";
			this.btnGuardarServicos.UseVisualStyleBackColor = false;
			this.btnGuardarServicos.Click += new System.EventHandler(this.btnGuardarServicos_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTotal.Location = new System.Drawing.Point(587, 193);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(65, 16);
			this.lblTotal.TabIndex = 37;
			this.lblTotal.Text = "Total: R$";
			// 
			// lboServicosEscolhidos
			// 
			this.lboServicosEscolhidos.BackColor = System.Drawing.SystemColors.Control;
			this.lboServicosEscolhidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lboServicosEscolhidos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lboServicosEscolhidos.FormattingEnabled = true;
			this.lboServicosEscolhidos.ItemHeight = 16;
			this.lboServicosEscolhidos.Location = new System.Drawing.Point(587, 287);
			this.lboServicosEscolhidos.Name = "lboServicosEscolhidos";
			this.lboServicosEscolhidos.Size = new System.Drawing.Size(192, 112);
			this.lboServicosEscolhidos.TabIndex = 38;
			// 
			// btnHorario
			// 
			this.btnHorario.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHorario.Location = new System.Drawing.Point(219, 276);
			this.btnHorario.Name = "btnHorario";
			this.btnHorario.Size = new System.Drawing.Size(75, 23);
			this.btnHorario.TabIndex = 40;
			this.btnHorario.Text = "Horário";
			this.btnHorario.UseVisualStyleBackColor = false;
			this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblData.Location = new System.Drawing.Point(587, 224);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(44, 16);
			this.lblData.TabIndex = 41;
			this.lblData.Text = "Data: ";
			// 
			// lblAgendamentos
			// 
			this.lblAgendamentos.AutoSize = true;
			this.lblAgendamentos.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblAgendamentos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgendamentos.Location = new System.Drawing.Point(412, 28);
			this.lblAgendamentos.Name = "lblAgendamentos";
			this.lblAgendamentos.Size = new System.Drawing.Size(124, 20);
			this.lblAgendamentos.TabIndex = 42;
			this.lblAgendamentos.Text = "Agendamentos";
			this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
			// 
			// lblHorario
			// 
			this.lblHorario.AutoSize = true;
			this.lblHorario.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblHorario.Location = new System.Drawing.Point(587, 257);
			this.lblHorario.Name = "lblHorario";
			this.lblHorario.Size = new System.Drawing.Size(63, 16);
			this.lblHorario.TabIndex = 43;
			this.lblHorario.Text = "Horário: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(25, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 44;
			this.label7.Text = "Nome";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(40, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 16);
			this.label8.TabIndex = 45;
			this.label8.Text = "Cpf";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(651, 155);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 16);
			this.label9.TabIndex = 46;
			this.label9.Text = "Resumo";
			// 
			// frmAgendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 511);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblHorario);
			this.Controls.Add(this.lblAgendamentos);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.btnHorario);
			this.Controls.Add(this.lboServicosEscolhidos);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAgendar);
			this.Controls.Add(this.btnGuardarServicos);
			this.Controls.Add(this.cklServicos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpData);
			this.Controls.Add(this.txbCpf);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblInicio);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblAgendar);
			this.Controls.Add(this.label2);
			this.Name = "frmAgendar";
			this.Text = "Agendar";
			this.Load += new System.EventHandler(this.Agendar_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblAgendar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.TextBox txbCpf;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox cklServicos;
		private System.Windows.Forms.Button btnAgendar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnGuardarServicos;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.ListBox lboServicosEscolhidos;
		private System.Windows.Forms.Button btnHorario;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblAgendamentos;
		private System.Windows.Forms.Label lblHorario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}