
namespace SistemaBarbearia.Design
{
	partial class frmAgendamentos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblAgendamentos = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblInicio = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblAgendar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvAgendamentos = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbClienteTelefone = new System.Windows.Forms.TextBox();
			this.txbClienteNome = new System.Windows.Forms.TextBox();
			this.btnExcluirCliente = new System.Windows.Forms.Button();
			this.txbValor = new System.Windows.Forms.TextBox();
			this.lboServicosEscolhidos = new System.Windows.Forms.ListBox();
			this.txbData = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAgendamentos
			// 
			this.lblAgendamentos.AutoSize = true;
			this.lblAgendamentos.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblAgendamentos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgendamentos.Location = new System.Drawing.Point(421, 27);
			this.lblAgendamentos.Name = "lblAgendamentos";
			this.lblAgendamentos.Size = new System.Drawing.Size(124, 20);
			this.lblAgendamentos.TabIndex = 13;
			this.lblAgendamentos.Text = "Agendamentos";
			this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblCliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCliente.Location = new System.Drawing.Point(328, 27);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(63, 20);
			this.lblCliente.TabIndex = 12;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
			// 
			// lblInicio
			// 
			this.lblInicio.AutoSize = true;
			this.lblInicio.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblInicio.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInicio.Location = new System.Drawing.Point(137, 27);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(53, 20);
			this.lblInicio.TabIndex = 11;
			this.lblInicio.Text = "Inicio";
			this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
			this.pictureBox1.Image = global::SistemaBarbearia.Properties.Resources.scissors_5550322_1280;
			this.pictureBox1.Location = new System.Drawing.Point(14, -9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 73);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// lblAgendar
			// 
			this.lblAgendar.AutoSize = true;
			this.lblAgendar.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblAgendar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgendar.Location = new System.Drawing.Point(220, 27);
			this.lblAgendar.Name = "lblAgendar";
			this.lblAgendar.Size = new System.Drawing.Size(75, 20);
			this.lblAgendar.TabIndex = 9;
			this.lblAgendar.Text = "Agendar";
			this.lblAgendar.Click += new System.EventHandler(this.lblAgendar_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(0, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(794, 65);
			this.label1.TabIndex = 8;
			// 
			// dgvAgendamentos
			// 
			this.dgvAgendamentos.AllowUserToAddRows = false;
			this.dgvAgendamentos.AllowUserToDeleteRows = false;
			this.dgvAgendamentos.AllowUserToResizeColumns = false;
			this.dgvAgendamentos.AllowUserToResizeRows = false;
			this.dgvAgendamentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvAgendamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAgendamentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvAgendamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dgvAgendamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAgendamentos.ColumnHeadersHeight = 30;
			this.dgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvAgendamentos.EnableHeadersVisualStyles = false;
			this.dgvAgendamentos.Location = new System.Drawing.Point(40, 174);
			this.dgvAgendamentos.Name = "dgvAgendamentos";
			this.dgvAgendamentos.ReadOnly = true;
			this.dgvAgendamentos.RowHeadersVisible = false;
			this.dgvAgendamentos.RowTemplate.Height = 25;
			this.dgvAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAgendamentos.Size = new System.Drawing.Size(243, 325);
			this.dgvAgendamentos.TabIndex = 14;
			this.dgvAgendamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamentos_CellClick);
			this.dgvAgendamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamentos_CellContentClick);
			this.dgvAgendamentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamentos_CellContentDoubleClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(567, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "Consulta agendamentos";
			// 
			// txbNome
			// 
			this.txbNome.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbNome.Location = new System.Drawing.Point(145, 143);
			this.txbNome.Name = "txbNome";
			this.txbNome.PlaceholderText = "Nome";
			this.txbNome.Size = new System.Drawing.Size(150, 25);
			this.txbNome.TabIndex = 39;
			this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNome_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(21, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "Nome do cliente";
			// 
			// txbClienteTelefone
			// 
			this.txbClienteTelefone.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbClienteTelefone.Location = new System.Drawing.Point(396, 237);
			this.txbClienteTelefone.Name = "txbClienteTelefone";
			this.txbClienteTelefone.PlaceholderText = "Telefone";
			this.txbClienteTelefone.ReadOnly = true;
			this.txbClienteTelefone.Size = new System.Drawing.Size(192, 25);
			this.txbClienteTelefone.TabIndex = 42;
			// 
			// txbClienteNome
			// 
			this.txbClienteNome.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbClienteNome.Location = new System.Drawing.Point(396, 183);
			this.txbClienteNome.Name = "txbClienteNome";
			this.txbClienteNome.PlaceholderText = "Nome";
			this.txbClienteNome.ReadOnly = true;
			this.txbClienteNome.Size = new System.Drawing.Size(281, 25);
			this.txbClienteNome.TabIndex = 41;
			// 
			// btnExcluirCliente
			// 
			this.btnExcluirCliente.BackColor = System.Drawing.Color.Coral;
			this.btnExcluirCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluirCliente.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnExcluirCliente.Location = new System.Drawing.Point(396, 447);
			this.btnExcluirCliente.Name = "btnExcluirCliente";
			this.btnExcluirCliente.Size = new System.Drawing.Size(92, 36);
			this.btnExcluirCliente.TabIndex = 40;
			this.btnExcluirCliente.Text = "Excluir";
			this.btnExcluirCliente.UseVisualStyleBackColor = false;
			this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirAgendamento_Click);
			// 
			// txbValor
			// 
			this.txbValor.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbValor.Location = new System.Drawing.Point(596, 295);
			this.txbValor.Name = "txbValor";
			this.txbValor.PlaceholderText = "Valor";
			this.txbValor.ReadOnly = true;
			this.txbValor.Size = new System.Drawing.Size(81, 25);
			this.txbValor.TabIndex = 49;
			this.txbValor.TextChanged += new System.EventHandler(this.txbValor_TextChanged);
			// 
			// lboServicosEscolhidos
			// 
			this.lboServicosEscolhidos.BackColor = System.Drawing.SystemColors.Control;
			this.lboServicosEscolhidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lboServicosEscolhidos.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lboServicosEscolhidos.FormattingEnabled = true;
			this.lboServicosEscolhidos.ItemHeight = 16;
			this.lboServicosEscolhidos.Location = new System.Drawing.Point(389, 345);
			this.lboServicosEscolhidos.Name = "lboServicosEscolhidos";
			this.lboServicosEscolhidos.Size = new System.Drawing.Size(192, 96);
			this.lboServicosEscolhidos.TabIndex = 50;
			// 
			// txbData
			// 
			this.txbData.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbData.Location = new System.Drawing.Point(396, 295);
			this.txbData.Name = "txbData";
			this.txbData.PlaceholderText = "Data";
			this.txbData.ReadOnly = true;
			this.txbData.Size = new System.Drawing.Size(117, 25);
			this.txbData.TabIndex = 51;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(328, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 52;
			this.label4.Text = "Nome";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(328, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 16);
			this.label5.TabIndex = 53;
			this.label5.Text = "Telefone";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(328, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 16);
			this.label6.TabIndex = 54;
			this.label6.Text = "Data";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(539, 298);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 16);
			this.label7.TabIndex = 55;
			this.label7.Text = "Valor";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(323, 345);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 16);
			this.label8.TabIndex = 56;
			this.label8.Text = "Servicos";
			// 
			// frmAgendamentos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 511);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txbData);
			this.Controls.Add(this.lboServicosEscolhidos);
			this.Controls.Add(this.txbValor);
			this.Controls.Add(this.txbClienteTelefone);
			this.Controls.Add(this.txbClienteNome);
			this.Controls.Add(this.btnExcluirCliente);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvAgendamentos);
			this.Controls.Add(this.lblAgendamentos);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.lblInicio);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblAgendar);
			this.Controls.Add(this.label1);
			this.Name = "frmAgendamentos";
			this.Text = "ConsultaAgendamentos";
			this.Load += new System.EventHandler(this.frmAgendamentos_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgendamentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAgendamentos;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblAgendar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAgendamentos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbClienteTelefone;
		private System.Windows.Forms.TextBox txbClienteNome;
		private System.Windows.Forms.Button btnExcluirCliente;
		private System.Windows.Forms.TextBox txbValor;
		private System.Windows.Forms.ListBox lboServicosEscolhidos;
		private System.Windows.Forms.TextBox txbData;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}