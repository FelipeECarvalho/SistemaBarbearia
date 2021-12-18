
namespace SistemaBarbearia.Design
{
	partial class frmEscolherCliente
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
			this.txtBuscaCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtBuscaCliente
			// 
			this.txtBuscaCliente.BackColor = System.Drawing.SystemColors.Window;
			this.txtBuscaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscaCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtBuscaCliente.Location = new System.Drawing.Point(31, 85);
			this.txtBuscaCliente.Name = "txtBuscaCliente";
			this.txtBuscaCliente.PlaceholderText = "Nome ou Cpf";
			this.txtBuscaCliente.Size = new System.Drawing.Size(179, 27);
			this.txtBuscaCliente.TabIndex = 24;
			this.txtBuscaCliente.TextChanged += new System.EventHandler(this.txtBuscaCliente_TextChanged);
			this.txtBuscaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaCliente_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(182, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 25);
			this.label4.TabIndex = 23;
			this.label4.Text = "Buscar cliente";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Coral;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCancelar.Location = new System.Drawing.Point(206, 376);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(102, 43);
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// dgvClientes
			// 
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(31, 118);
			this.dgvClientes.MultiSelect = false;
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowHeadersVisible = false;
			this.dgvClientes.RowTemplate.Height = 25;
			this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClientes.Size = new System.Drawing.Size(444, 235);
			this.dgvClientes.TabIndex = 27;
			this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
			// 
			// frmEscolherCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 431);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtBuscaCliente);
			this.Controls.Add(this.label4);
			this.Name = "frmEscolherCliente";
			this.Text = "EscolherCliente";
			this.Load += new System.EventHandler(this.EscolherCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBuscaCliente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView dgvClientes;
	}
}