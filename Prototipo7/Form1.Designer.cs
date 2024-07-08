namespace Prototipo7
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IdCliente = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelregistroSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelmenuSubMenu = new System.Windows.Forms.Panel();
            this.Entradas = new System.Windows.Forms.Button();
            this.Promociones = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.Desplegar = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelregistroSubMenu.SuspendLayout();
            this.PanelmenuSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(88)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IdCliente);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PanelregistroSubMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PanelmenuSubMenu);
            this.panel1.Controls.Add(this.Desplegar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 542);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Id Cliente:";
            // 
            // IdCliente
            // 
            this.IdCliente.Enabled = false;
            this.IdCliente.Location = new System.Drawing.Point(74, 473);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(61, 29);
            this.IdCliente.TabIndex = 70;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(11, 408);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 29);
            this.txtUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // PanelregistroSubMenu
            // 
            this.PanelregistroSubMenu.BackColor = System.Drawing.Color.White;
            this.PanelregistroSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelregistroSubMenu.Controls.Add(this.button5);
            this.PanelregistroSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelregistroSubMenu.Location = new System.Drawing.Point(0, 183);
            this.PanelregistroSubMenu.Name = "PanelregistroSubMenu";
            this.PanelregistroSubMenu.Size = new System.Drawing.Size(190, 45);
            this.PanelregistroSubMenu.TabIndex = 4;
            this.PanelregistroSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelregistroSubMenu_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(188, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = "Nuestro equipo";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(88)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mas opciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelmenuSubMenu
            // 
            this.PanelmenuSubMenu.BackColor = System.Drawing.Color.White;
            this.PanelmenuSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelmenuSubMenu.Controls.Add(this.Entradas);
            this.PanelmenuSubMenu.Controls.Add(this.Promociones);
            this.PanelmenuSubMenu.Controls.Add(this.Menu);
            this.PanelmenuSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelmenuSubMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelmenuSubMenu.Location = new System.Drawing.Point(0, 31);
            this.PanelmenuSubMenu.Name = "PanelmenuSubMenu";
            this.PanelmenuSubMenu.Size = new System.Drawing.Size(190, 121);
            this.PanelmenuSubMenu.TabIndex = 2;
            // 
            // Entradas
            // 
            this.Entradas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Entradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entradas.Location = new System.Drawing.Point(0, 84);
            this.Entradas.Name = "Entradas";
            this.Entradas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Entradas.Size = new System.Drawing.Size(188, 36);
            this.Entradas.TabIndex = 2;
            this.Entradas.Text = "Postres";
            this.Entradas.UseVisualStyleBackColor = false;
            this.Entradas.Click += new System.EventHandler(this.Entradas_Click);
            // 
            // Promociones
            // 
            this.Promociones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Promociones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Promociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Promociones.Location = new System.Drawing.Point(0, 41);
            this.Promociones.Name = "Promociones";
            this.Promociones.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Promociones.Size = new System.Drawing.Size(188, 43);
            this.Promociones.TabIndex = 1;
            this.Promociones.Text = "Bebidas";
            this.Promociones.UseVisualStyleBackColor = false;
            this.Promociones.Click += new System.EventHandler(this.Promociones_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Menu.Size = new System.Drawing.Size(188, 41);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Pizzas";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Desplegar
            // 
            this.Desplegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(88)))));
            this.Desplegar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Desplegar.FlatAppearance.BorderSize = 0;
            this.Desplegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desplegar.ForeColor = System.Drawing.Color.White;
            this.Desplegar.Location = new System.Drawing.Point(0, 0);
            this.Desplegar.Name = "Desplegar";
            this.Desplegar.Size = new System.Drawing.Size(190, 31);
            this.Desplegar.TabIndex = 1;
            this.Desplegar.Text = "Desplegar";
            this.Desplegar.UseVisualStyleBackColor = false;
            this.Desplegar.Click += new System.EventHandler(this.Desplegar_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChildForm.BackgroundImage")));
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildForm.Location = new System.Drawing.Point(192, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(847, 546);
            this.panelChildForm.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 542);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelregistroSubMenu.ResumeLayout(false);
            this.PanelmenuSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Desplegar;
		private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IdCliente;
        private System.Windows.Forms.Panel PanelregistroSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel PanelmenuSubMenu;
        private System.Windows.Forms.Button Entradas;
        private System.Windows.Forms.Button Promociones;
        private System.Windows.Forms.Button Menu;
    }
}

