namespace pjRegistro_Inventario
{
    partial class frmTotalInv
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
            this.sacarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvInventarioTotal = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductosToolStripMenuItem,
            this.sacarProductosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ingresarProductosToolStripMenuItem
            // 
            this.ingresarProductosToolStripMenuItem.Name = "ingresarProductosToolStripMenuItem";
            this.ingresarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresarProductosToolStripMenuItem.Text = "Ingresar Productos";
            this.ingresarProductosToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductosToolStripMenuItem_Click);
            // 
            // sacarProductosToolStripMenuItem
            // 
            this.sacarProductosToolStripMenuItem.Name = "sacarProductosToolStripMenuItem";
            this.sacarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sacarProductosToolStripMenuItem.Text = "Sacar Productos";
            this.sacarProductosToolStripMenuItem.Click += new System.EventHandler(this.sacarProductosToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // lvInventarioTotal
            // 
            this.lvInventarioTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvInventarioTotal.GridLines = true;
            this.lvInventarioTotal.Location = new System.Drawing.Point(31, 79);
            this.lvInventarioTotal.Name = "lvInventarioTotal";
            this.lvInventarioTotal.Size = new System.Drawing.Size(470, 165);
            this.lvInventarioTotal.TabIndex = 16;
            this.lvInventarioTotal.UseCompatibleStateImageBehavior = false;
            this.lvInventarioTotal.View = System.Windows.Forms.View.Details;
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
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inventario de Germs S.A.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Aqui se deberia ver el inv completo\r\npero no puedo compartir datos";
            // 
            // frmTotalInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvInventarioTotal);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTotalInv";
            this.Text = "Productos en Inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ingresarProductosToolStripMenuItem;
        private ToolStripMenuItem creditosToolStripMenuItem;
        private ToolStripMenuItem sacarProductosToolStripMenuItem;
        private ListView lvInventarioTotal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;
        private Label label2;
    }
}