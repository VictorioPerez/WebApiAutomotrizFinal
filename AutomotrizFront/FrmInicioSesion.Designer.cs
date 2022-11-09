namespace AutomotrizFront
{
    partial class FrmInicioSesion
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSubmenuVehi = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnModificarV = new System.Windows.Forms.Button();
            this.btnConsultarV = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.panelSubmenuAuto = new System.Windows.Forms.Panel();
            this.btnConsultarA = new System.Windows.Forms.Button();
            this.btnAutopartes = new System.Windows.Forms.Button();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.BtnReportePruebaV = new System.Windows.Forms.Button();
            this.btnReporteAutoparte = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubmenuVehi.SuspendLayout();
            this.panelSubmenuAuto.SuspendLayout();
            this.panelIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panelSideMenu.Controls.Add(this.btnSalir);
            this.panelSideMenu.Controls.Add(this.panelSubmenuVehi);
            this.panelSideMenu.Controls.Add(this.btnVehiculos);
            this.panelSideMenu.Controls.Add(this.panelSubmenuAuto);
            this.panelSideMenu.Controls.Add(this.btnAutopartes);
            this.panelSideMenu.Controls.Add(this.panelIcono);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 494);
            this.panelSideMenu.TabIndex = 7;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(0, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(250, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelSubmenuVehi
            // 
            this.panelSubmenuVehi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenuVehi.Controls.Add(this.BtnReportePruebaV);
            this.panelSubmenuVehi.Controls.Add(this.btnFactura);
            this.panelSubmenuVehi.Controls.Add(this.btnModificarV);
            this.panelSubmenuVehi.Controls.Add(this.btnConsultarV);
            this.panelSubmenuVehi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuVehi.Location = new System.Drawing.Point(0, 273);
            this.panelSubmenuVehi.Name = "panelSubmenuVehi";
            this.panelSubmenuVehi.Size = new System.Drawing.Size(250, 165);
            this.panelSubmenuVehi.TabIndex = 4;
            this.panelSubmenuVehi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSubmenuVehi_Paint);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFactura.Location = new System.Drawing.Point(0, 78);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFactura.Size = new System.Drawing.Size(250, 40);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Facturar Vehiculo";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click_1);
            // 
            // btnModificarV
            // 
            this.btnModificarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnModificarV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarV.FlatAppearance.BorderSize = 0;
            this.btnModificarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarV.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificarV.Location = new System.Drawing.Point(0, 40);
            this.btnModificarV.Name = "btnModificarV";
            this.btnModificarV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnModificarV.Size = new System.Drawing.Size(250, 38);
            this.btnModificarV.TabIndex = 2;
            this.btnModificarV.Text = "Insertar Vehiculo";
            this.btnModificarV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarV.UseVisualStyleBackColor = false;
            this.btnModificarV.Click += new System.EventHandler(this.butbtnModificarV_Click);
            // 
            // btnConsultarV
            // 
            this.btnConsultarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnConsultarV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarV.FlatAppearance.BorderSize = 0;
            this.btnConsultarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarV.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarV.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarV.Name = "btnConsultarV";
            this.btnConsultarV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarV.Size = new System.Drawing.Size(250, 40);
            this.btnConsultarV.TabIndex = 0;
            this.btnConsultarV.Text = "Consultar";
            this.btnConsultarV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarV.UseVisualStyleBackColor = false;
            this.btnConsultarV.Click += new System.EventHandler(this.btnConsultarV_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 228);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVehiculos.Size = new System.Drawing.Size(250, 45);
            this.btnVehiculos.TabIndex = 3;
            this.btnVehiculos.Text = "Vehiculos                                                       v  ";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // panelSubmenuAuto
            // 
            this.panelSubmenuAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubmenuAuto.Controls.Add(this.btnReporteAutoparte);
            this.panelSubmenuAuto.Controls.Add(this.btnConsultarA);
            this.panelSubmenuAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuAuto.Location = new System.Drawing.Point(0, 145);
            this.panelSubmenuAuto.Name = "panelSubmenuAuto";
            this.panelSubmenuAuto.Size = new System.Drawing.Size(250, 83);
            this.panelSubmenuAuto.TabIndex = 2;
            // 
            // btnConsultarA
            // 
            this.btnConsultarA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarA.FlatAppearance.BorderSize = 0;
            this.btnConsultarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarA.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarA.Name = "btnConsultarA";
            this.btnConsultarA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultarA.Size = new System.Drawing.Size(250, 40);
            this.btnConsultarA.TabIndex = 0;
            this.btnConsultarA.Text = "Consultar";
            this.btnConsultarA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarA.UseVisualStyleBackColor = true;
            this.btnConsultarA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutopartes
            // 
            this.btnAutopartes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutopartes.FlatAppearance.BorderSize = 0;
            this.btnAutopartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutopartes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutopartes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutopartes.Location = new System.Drawing.Point(0, 100);
            this.btnAutopartes.Name = "btnAutopartes";
            this.btnAutopartes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAutopartes.Size = new System.Drawing.Size(250, 45);
            this.btnAutopartes.TabIndex = 1;
            this.btnAutopartes.Text = "Autopartes                                                    v  ";
            this.btnAutopartes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutopartes.UseVisualStyleBackColor = true;
            this.btnAutopartes.Click += new System.EventHandler(this.btnAutopartes_Click);
            // 
            // panelIcono
            // 
            this.panelIcono.Controls.Add(this.pictureBox1);
            this.panelIcono.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcono.Location = new System.Drawing.Point(0, 0);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(250, 100);
            this.panelIcono.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomotrizFront.Properties.Resources.logoAutomoro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.White;
            this.panelForms.Controls.Add(this.groupBox1);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(250, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1115, 494);
            this.panelForms.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.btnInicio);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Location = new System.Drawing.Point(200, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar sesion";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(251, 134);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(171, 23);
            this.txtUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(130, 137);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(297, 239);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(130, 166);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 15);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(251, 163);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(171, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // BtnReportePruebaV
            // 
            this.BtnReportePruebaV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.BtnReportePruebaV.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportePruebaV.FlatAppearance.BorderSize = 0;
            this.BtnReportePruebaV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportePruebaV.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnReportePruebaV.Location = new System.Drawing.Point(0, 118);
            this.BtnReportePruebaV.Name = "BtnReportePruebaV";
            this.BtnReportePruebaV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnReportePruebaV.Size = new System.Drawing.Size(250, 40);
            this.BtnReportePruebaV.TabIndex = 3;
            this.BtnReportePruebaV.Text = "Reporte Prueba";
            this.BtnReportePruebaV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportePruebaV.UseVisualStyleBackColor = false;
            // 
            // btnReporteAutoparte
            // 
            this.btnReporteAutoparte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteAutoparte.FlatAppearance.BorderSize = 0;
            this.btnReporteAutoparte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAutoparte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporteAutoparte.Location = new System.Drawing.Point(0, 40);
            this.btnReporteAutoparte.Name = "btnReporteAutoparte";
            this.btnReporteAutoparte.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteAutoparte.Size = new System.Drawing.Size(250, 40);
            this.btnReporteAutoparte.TabIndex = 1;
            this.btnReporteAutoparte.Text = "Reporte Prueba";
            this.btnReporteAutoparte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteAutoparte.UseVisualStyleBackColor = true;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1365, 494);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubmenuVehi.ResumeLayout(false);
            this.panelSubmenuAuto.ResumeLayout(false);
            this.panelIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelSideMenu;
        private Panel panelIcono;
        private Panel panelSubmenuVehi;
        private Button btnVehiculos;
        private Panel panelSubmenuAuto;
        private Button btnConsultarA;
        private Panel panelForms;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnConsultarV;
        private Button btnModificarV;
        private Button btnFactura;
        public Button btnAutopartes;
        private GroupBox groupBox1;
        private TextBox txtUser;
        private Label lblUser;
        public Button btnInicio;
        private Label lblPass;
        private TextBox txtPass;
        private Button BtnReportePruebaV;
        private Button btnReporteAutoparte;
    }
}