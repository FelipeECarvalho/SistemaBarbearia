
namespace SistemaBarbearia
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbUsuario = new System.Windows.Forms.TextBox();
			this.txbSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(168, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(168, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha";
			// 
			// txbUsuario
			// 
			this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbUsuario.Location = new System.Drawing.Point(168, 279);
			this.txbUsuario.Name = "txbUsuario";
			this.txbUsuario.Size = new System.Drawing.Size(194, 23);
			this.txbUsuario.TabIndex = 2;
			this.txbUsuario.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
			// 
			// txbSenha
			// 
			this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbSenha.Location = new System.Drawing.Point(168, 346);
			this.txbSenha.Name = "txbSenha";
			this.txbSenha.Size = new System.Drawing.Size(194, 23);
			this.txbSenha.TabIndex = 3;
			this.txbSenha.UseSystemPasswordChar = true;
			this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.btnEntrar.Location = new System.Drawing.Point(287, 391);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 35);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(177, 87);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(172, 137);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.btnSair.Location = new System.Drawing.Point(168, 391);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 35);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(177, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.Goldenrod;
			this.label6.Location = new System.Drawing.Point(183, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 27);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cortamos cabelos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Orange;
			this.label3.Location = new System.Drawing.Point(58, -6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(444, 63);
			this.label3.TabIndex = 61;
			this.label3.Text = "Barbearia C Sharp";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(533, 476);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txbSenha);
			this.Controls.Add(this.txbUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbUsuario;
		private System.Windows.Forms.TextBox txbSenha;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
	}
}

