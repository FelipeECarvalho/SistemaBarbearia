
namespace SistemaBarbearia.Design
{
	partial class frmCadastro
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbNome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbCPF = new System.Windows.Forms.MaskedTextBox();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.txbCancelar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(76, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(76, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome";
			// 
			// txbNome
			// 
			this.txbNome.BackColor = System.Drawing.SystemColors.Window;
			this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbNome.Location = new System.Drawing.Point(76, 88);
			this.txbNome.Name = "txbNome";
			this.txbNome.Size = new System.Drawing.Size(263, 23);
			this.txbNome.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(76, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Email";
			// 
			// txbEmail
			// 
			this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbEmail.Location = new System.Drawing.Point(79, 154);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(260, 23);
			this.txbEmail.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(79, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "CPF";
			// 
			// txbCPF
			// 
			this.txbCPF.BeepOnError = true;
			this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbCPF.Location = new System.Drawing.Point(79, 216);
			this.txbCPF.Mask = "000.000.000-00";
			this.txbCPF.Name = "txbCPF";
			this.txbCPF.ShortcutsEnabled = false;
			this.txbCPF.Size = new System.Drawing.Size(139, 29);
			this.txbCPF.TabIndex = 8;
			this.txbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// btnCadastro
			// 
			this.btnCadastro.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.btnCadastro.Location = new System.Drawing.Point(198, 354);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(75, 35);
			this.btnCadastro.TabIndex = 13;
			this.btnCadastro.Text = "Enviar";
			this.btnCadastro.UseVisualStyleBackColor = false;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// txbCancelar
			// 
			this.txbCancelar.BackColor = System.Drawing.Color.LightSkyBlue;
			this.txbCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txbCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.txbCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txbCancelar.Location = new System.Drawing.Point(76, 354);
			this.txbCancelar.Name = "txbCancelar";
			this.txbCancelar.Size = new System.Drawing.Size(91, 35);
			this.txbCancelar.TabIndex = 14;
			this.txbCancelar.Text = "Cancelar";
			this.txbCancelar.UseVisualStyleBackColor = false;
			this.txbCancelar.Click += new System.EventHandler(this.txbCancelar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(79, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 21);
			this.label5.TabIndex = 15;
			this.label5.Text = "Telefone";
			// 
			// txbTelefone
			// 
			this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txbTelefone.Location = new System.Drawing.Point(79, 285);
			this.txbTelefone.Mask = "(99) 0 0000-0000";
			this.txbTelefone.Name = "txbTelefone";
			this.txbTelefone.ShortcutsEnabled = false;
			this.txbTelefone.Size = new System.Drawing.Size(194, 29);
			this.txbTelefone.TabIndex = 16;
			this.txbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(417, 431);
			this.Controls.Add(this.txbTelefone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txbCancelar);
			this.Controls.Add(this.btnCadastro);
			this.Controls.Add(this.txbCPF);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txbEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmCadastro";
			this.Text = "Cadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbNome;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txbCPF;
		private System.Windows.Forms.Button btnCadastro;
		private System.Windows.Forms.Button txbCancelar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txbTelefone;
	}
}