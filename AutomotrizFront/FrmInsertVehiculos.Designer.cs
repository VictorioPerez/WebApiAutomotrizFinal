namespace AutomotrizFront
{
    partial class FrmInsertVehiculos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numCantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.dgvDetalles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboColor);
            this.groupBox2.Controls.Add(this.cboMarcas);
            this.groupBox2.Controls.Add(this.cboModelo);
            this.groupBox2.Location = new System.Drawing.Point(40, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1026, 316);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Vehiculo";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(421, 247);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(335, 23);
            this.numCantidad.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Stock";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(395, 281);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(192, 30);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(798, 254);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 30);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColDescripcion,
            this.ColMarca,
            this.ColModelo,
            this.ColColor,
            this.ColPrecio,
            this.ColAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(352, 39);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 29;
            this.dgvDetalles.Size = new System.Drawing.Size(674, 203);
            this.dgvDetalles.TabIndex = 8;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 125;
            // 
            // ColMarca
            // 
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.MinimumWidth = 6;
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            this.ColMarca.Width = 125;
            // 
            // ColModelo
            // 
            this.ColModelo.HeaderText = "Modelo";
            this.ColModelo.MinimumWidth = 6;
            this.ColModelo.Name = "ColModelo";
            this.ColModelo.ReadOnly = true;
            this.ColModelo.Width = 125;
            // 
            // ColColor
            // 
            this.ColColor.HeaderText = "Color";
            this.ColColor.MinimumWidth = 6;
            this.ColColor.Name = "ColColor";
            this.ColColor.ReadOnly = true;
            this.ColColor.Width = 125;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 125;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(127, 240);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 23);
            this.txtPrecio.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(119, 196);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 23);
            this.txtDescripcion.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Descripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Marca";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(119, 138);
            this.cboColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(204, 23);
            this.cboColor.TabIndex = 4;
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(119, 37);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(204, 23);
            this.cboMarcas.TabIndex = 1;
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(119, 86);
            this.cboModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(204, 23);
            this.cboModelo.TabIndex = 2;
            // 
            // FrmInsertVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 347);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInsertVehiculos";
            this.Text = "FrmInsertVehiculos";
            this.Load += new System.EventHandler(this.FrmInsertVehiculos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button btnAgregar;
        private DataGridView dgvDetalles;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColModelo;
        private DataGridViewTextBoxColumn ColColor;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAcciones;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboColor;
        private ComboBox cboMarcas;
        private ComboBox cboModelo;
        private Button btnAceptar;
        private NumericUpDown numCantidad;
        private Label label2;
    }
}