namespace pjRegistro_Inventario
{
    partial class frmRetiro
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
            this.ingresarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvRetiro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductosToolStripMenuItem,
            this.visualizarInventarioToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ingresarProductosToolStripMenuItem
            // 
            this.ingresarProductosToolStripMenuItem.Name = "ingresarProductosToolStripMenuItem";
            this.ingresarProductosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ingresarProductosToolStripMenuItem.Text = "Ingresar Productos";
            this.ingresarProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductosToolStripMenuItem_Click);
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
            // lvRetiro
            // 
            this.lvRetiro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvRetiro.GridLines = true;
            this.lvRetiro.Location = new System.Drawing.Point(30, 131);
            this.lvRetiro.Name = "lvRetiro";
            this.lvRetiro.Size = new System.Drawing.Size(470, 122);
            this.lvRetiro.TabIndex = 15;
            this.lvRetiro.UseCompatibleStateImageBehavior = false;
            this.lvRetiro.View = System.Windows.Forms.View.Details;
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
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Color";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Retiro de Productos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirmar Retiro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Unidad",
            "Tipo",
            "Color",
            "Tamaño",
            "Precio"});
            this.comboBox1.Location = new System.Drawing.Point(30, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 23);
            this.comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 23);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccione Caracteristica";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(441, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Esto es solo para hacer funcionar el menustrip \r\nAun no se como compartir datos e" +
    "ntre forms y listview\r\n";
            // 
            // frmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvRetiro);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRetiro";
            this.Text = "Retiro de Productos Germs S.A.";
            this.Load += new System.EventHandler(this.frmRetiro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ingresarProductosToolStripMenuItem;
        private ToolStripMenuItem visualizarInventarioToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private ListView lvRetiro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Button btnBuscar;
        private Label label3;
    }
}