
namespace SistemaBarbearia.Design
{
	partial class frmCliente
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblInicio = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblAgendar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.btnExcluirCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBuscaCliente = new System.Windows.Forms.TextBox();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.txbCpf = new System.Windows.Forms.TextBox();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.txbTelefone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAtualizarCliente = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblAgendamentos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblCliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCliente.Location = new System.Drawing.Point(327, 28);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(63, 20);
			this.lblCliente.TabIndex = 11;
			this.lblCliente.Text = "Cliente";
			// 
			// lblInicio
			// 
			this.lblInicio.AutoSize = true;
			this.lblInicio.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblInicio.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInicio.Location = new System.Drawing.Point(136, 28);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(53, 20);
			this.lblInicio.TabIndex = 10;
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
			this.pictureBox1.TabIndex = 9;
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
			this.lblAgendar.TabIndex = 8;
			this.lblAgendar.Text = "Agendar";
			this.lblAgendar.Click += new System.EventHandler(this.lblAgendar_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(-1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(794, 65);
			this.label1.TabIndex = 7;
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.AllowUserToResizeColumns = false;
			this.dgvClientes.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvClientes.ColumnHeadersHeight = 30;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvClientes.EnableHeadersVisualStyles = false;
			this.dgvClientes.Location = new System.Drawing.Point(13, 191);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowHeadersVisible = false;
			this.dgvClientes.RowTemplate.Height = 25;
			this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClientes.Size = new System.Drawing.Size(443, 308);
			this.dgvClientes.TabIndex = 14;
			this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
			// 
			// btnCadastro
			// 
			this.btnCadastro.BackColor = System.Drawing.Color.Lime;
			this.btnCadastro.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCadastro.Location = new System.Drawing.Point(11, 155);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(159, 32);
			this.btnCadastro.TabIndex = 15;
			this.btnCadastro.Text = "Cadastrar um cliente";
			this.btnCadastro.UseVisualStyleBackColor = false;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// btnExcluirCliente
			// 
			this.btnExcluirCliente.BackColor = System.Drawing.Color.Coral;
			this.btnExcluirCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluirCliente.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnExcluirCliente.Location = new System.Drawing.Point(477, 448);
			this.btnExcluirCliente.Name = "btnExcluirCliente";
			this.btnExcluirCliente.Size = new System.Drawing.Size(124, 32);
			this.btnExcluirCliente.TabIndex = 17;
			this.btnExcluirCliente.Text = "Excluir cliente";
			this.btnExcluirCliente.UseVisualStyleBackColor = false;
			this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(176, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Buscar cliente";
			// 
			// txtBuscaCliente
			// 
			this.txtBuscaCliente.BackColor = System.Drawing.SystemColors.Window;
			this.txtBuscaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscaCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtBuscaCliente.Location = new System.Drawing.Point(277, 158);
			this.txtBuscaCliente.Name = "txtBuscaCliente";
			this.txtBuscaCliente.PlaceholderText = "Nome ou Cpf";
			this.txtBuscaCliente.Size = new System.Drawing.Size(179, 27);
			this.txtBuscaCliente.TabIndex = 19;
			this.txtBuscaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaCliente_KeyPress);
			// 
			// txbNome
			// 
			this.txbNome.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbNome.Location = new System.Drawing.Point(477, 209);
			this.txbNome.Name = "txbNome";
			this.txbNome.PlaceholderText = "Nome";
			this.txbNome.ReadOnly = true;
			this.txbNome.Size = new System.Drawing.Size(281, 25);
			this.txbNome.TabIndex = 20;
			// 
			// txbCpf
			// 
			this.txbCpf.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbCpf.Location = new System.Drawing.Point(477, 267);
			this.txbCpf.Name = "txbCpf";
			this.txbCpf.PlaceholderText = "Cpf";
			this.txbCpf.ReadOnly = true;
			this.txbCpf.Size = new System.Drawing.Size(200, 25);
			this.txbCpf.TabIndex = 21;
			// 
			// txbEmail
			// 
			this.txbEmail.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbEmail.Location = new System.Drawing.Point(477, 320);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.PlaceholderText = "Email";
			this.txbEmail.ReadOnly = true;
			this.txbEmail.Size = new System.Drawing.Size(281, 25);
			this.txbEmail.TabIndex = 22;
			// 
			// txbTelefone
			// 
			this.txbTelefone.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txbTelefone.Location = new System.Drawing.Point(477, 374);
			this.txbTelefone.Name = "txbTelefone";
			this.txbTelefone.PlaceholderText = "Telefone";
			this.txbTelefone.ReadOnly = true;
			this.txbTelefone.Size = new System.Drawing.Size(200, 25);
			this.txbTelefone.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(596, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "Gestão de clientes";
			// 
			// btnAtualizarCliente
			// 
			this.btnAtualizarCliente.BackColor = System.Drawing.Color.SkyBlue;
			this.btnAtualizarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizarCliente.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAtualizarCliente.Location = new System.Drawing.Point(634, 448);
			this.btnAtualizarCliente.Name = "btnAtualizarCliente";
			this.btnAtualizarCliente.Size = new System.Drawing.Size(124, 32);
			this.btnAtualizarCliente.TabIndex = 25;
			this.btnAtualizarCliente.Text = "Atualizar cliente";
			this.btnAtualizarCliente.UseVisualStyleBackColor = false;
			this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.Lime;
			this.btnOk.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnOk.Location = new System.Drawing.Point(525, 155);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(76, 32);
			this.btnOk.TabIndex = 26;
			this.btnOk.Text = "Atualizar";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Visible = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Coral;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCancelar.Location = new System.Drawing.Point(634, 155);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(72, 32);
			this.btnCancelar.TabIndex = 27;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblAgendamentos
			// 
			this.lblAgendamentos.AutoSize = true;
			this.lblAgendamentos.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblAgendamentos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAgendamentos.Location = new System.Drawing.Point(419, 28);
			this.lblAgendamentos.Name = "lblAgendamentos";
			this.lblAgendamentos.Size = new System.Drawing.Size(124, 20);
			this.lblAgendamentos.TabIndex = 28;
			this.lblAgendamentos.Text = "Agendamentos";
			this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 511);
			this.Controls.Add(this.lblAgendamentos);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnAtualizarCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbTelefone);
			this.Controls.Add(this.txbEmail);
			this.Controls.Add(this.txbCpf);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.txtBuscaCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnExcluirCliente);
			this.Controls.Add(this.btnCadastro);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.lblInicio);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblAgendar);
			this.Controls.Add(this.label1);
			this.Name = "frmCliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.frmCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblAgendar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnCadastro;
		private System.Windows.Forms.Button btnExcluirCliente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBuscaCliente;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.TextBox txbCpf;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.TextBox txbTelefone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAtualizarCliente;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblAgendamentos;
	}
}