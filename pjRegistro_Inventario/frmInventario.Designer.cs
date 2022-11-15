namespace pjRegistro_Inventario
{
    partial class frmInventario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lvEntregas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboTamaño = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblN_Entrega = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgProgreso = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sacarProductosToolStripMenuItem,
            this.visualizarInventarioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // sacarProductosToolStripMenuItem
            // 
            this.sacarProductosToolStripMenuItem.Name = "sacarProductosToolStripMenuItem";
            this.sacarProductosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sacarProductosToolStripMenuItem.Text = "Sacar Productos";
            this.sacarProductosToolStripMenuItem.Click += new System.EventHandler(this.sacarProductosToolStripMenuItem_Click);
            // 
            // visualizarInventarioToolStripMenuItem
            // 
            this.visualizarInventarioToolStripMenuItem.Name = "visualizarInventarioToolStripMenuItem";
            this.visualizarInventarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.visualizarInventarioToolStripMenuItem.Text = "Visualizar Inventario";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(463, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 23);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label7";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(455, 399);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lvEntregas
            // 
            this.lvEntregas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEntregas.GridLines = true;
            this.lvEntregas.Location = new System.Drawing.Point(20, 290);
            this.lvEntregas.Name = "lvEntregas";
            this.lvEntregas.Size = new System.Drawing.Size(510, 96);
            this.lvEntregas.TabIndex = 21;
            this.lvEntregas.UseCompatibleStateImageBehavior = false;
            this.lvEntregas.View = System.Windows.Forms.View.Details;
            this.lvEntregas.SelectedIndexChanged += new System.EventHandler(this.lvEntregas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Color";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tamaño";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Precio";
            this.columnHeader7.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnIngreso);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.cboColor);
            this.groupBox1.Controls.Add(this.cboTamaño);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblN_Entrega);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 215);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "N° Entrega";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(179, 183);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 35;
            this.btnIngreso.Text = "Confirmar Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Muebles",
            "Electrodomesticos",
            "Vehiculos",
            "Consolas",
            "Celulares",
            "Joyeria"});
            this.cboTipo.Location = new System.Drawing.Point(290, 46);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(96, 23);
            this.cboTipo.TabIndex = 34;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Amarrillo",
            "Cafe",
            "Gris",
            "Morado",
            "Negro",
            "Blanco"});
            this.cboColor.Location = new System.Drawing.Point(29, 112);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(92, 23);
            this.cboColor.TabIndex = 33;
            // 
            // cboTamaño
            // 
            this.cboTamaño.FormattingEnabled = true;
            this.cboTamaño.Items.AddRange(new object[] {
            "Grande",
            "Mediano",
            "Pequeño",
            "Otros"});
            this.cboTamaño.Location = new System.Drawing.Point(29, 180);
            this.cboTamaño.Name = "cboTamaño";
            this.cboTamaño.Size = new System.Drawing.Size(92, 23);
            this.cboTamaño.TabIndex = 32;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(290, 112);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(75, 23);
            this.txtPrecio.TabIndex = 31;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(157, 112);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(69, 23);
            this.txtUnidad.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(97, 23);
            this.txtNombre.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(29, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 23);
            this.txtId.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tamaño";
            // 
            // lblN_Entrega
            // 
            this.lblN_Entrega.AutoSize = true;
            this.lblN_Entrega.Location = new System.Drawing.Point(419, 183);
            this.lblN_Entrega.Name = "lblN_Entrega";
            this.lblN_Entrega.Size = new System.Drawing.Size(38, 15);
            this.lblN_Entrega.TabIndex = 26;
            this.lblN_Entrega.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID-Producto";
            // 
            // pgProgreso
            // 
            this.pgProgreso.Location = new System.Drawing.Point(342, 399);
            this.pgProgreso.Name = "pgProgreso";
            this.pgProgreso.Size = new System.Drawing.Size(75, 23);
            this.pgProgreso.TabIndex = 37;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 434);
            this.Controls.Add(this.pgProgreso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvEntregas);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInventario";
            this.Text = "Ingresar Productos Germs S.A.";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem sacarProductosToolStripMenuItem;
        private ToolStripMenuItem visualizarInventarioToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private Label lblFecha;
        private Button btnEnviar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        public ListView lvEntregas;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnIngreso;
        private ComboBox cboTipo;
        private ComboBox cboColor;
        private ComboBox cboTamaño;
        private TextBox txtPrecio;
        private TextBox txtUnidad;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label9;
        private Label lblN_Entrega;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ProgressBar pgProgreso;
    }
}