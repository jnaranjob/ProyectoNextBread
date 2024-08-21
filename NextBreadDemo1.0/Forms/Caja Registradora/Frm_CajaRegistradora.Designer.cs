namespace NextBreadDemo1._0.Forms.Caja_Registradora
{
    partial class Frm_CajaRegistradora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CajaRegistradora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dtp_FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.Txt_CodigoVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_CodigoP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_PrecioProducto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Cb_TipoPago = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarAgregarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Dgv_ProveedoresRegistrados = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btn_CancelarCompra = new System.Windows.Forms.Button();
            this.Btn_QuitarProducto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Facturar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Txt_TotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.Txt_SubTotal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pb_Usuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProveedoresRegistrados)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(156, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 110);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.Dtp_FechaCompra);
            this.panel2.Controls.Add(this.Txt_CodigoVenta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Lbl_CodigoP);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 103);
            this.panel2.TabIndex = 1;
            // 
            // Dtp_FechaCompra
            // 
            this.Dtp_FechaCompra.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaCompra.Enabled = false;
            this.Dtp_FechaCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaCompra.Location = new System.Drawing.Point(119, 71);
            this.Dtp_FechaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_FechaCompra.Name = "Dtp_FechaCompra";
            this.Dtp_FechaCompra.Size = new System.Drawing.Size(292, 25);
            this.Dtp_FechaCompra.TabIndex = 9;
            // 
            // Txt_CodigoVenta
            // 
            this.Txt_CodigoVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoVenta.Location = new System.Drawing.Point(119, 18);
            this.Txt_CodigoVenta.Name = "Txt_CodigoVenta";
            this.Txt_CodigoVenta.Size = new System.Drawing.Size(292, 25);
            this.Txt_CodigoVenta.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // Lbl_CodigoP
            // 
            this.Lbl_CodigoP.AutoSize = true;
            this.Lbl_CodigoP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoP.Location = new System.Drawing.Point(3, 18);
            this.Lbl_CodigoP.Name = "Lbl_CodigoP";
            this.Lbl_CodigoP.Size = new System.Drawing.Size(110, 17);
            this.Lbl_CodigoP.TabIndex = 0;
            this.Lbl_CodigoP.Text = "Codigo de Venta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(13, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 205);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.Txt_Cantidad);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.Txt_CodigoProducto);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.Txt_PrecioProducto);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Txt_Descripcion);
            this.panel5.Controls.Add(this.Cb_TipoPago);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(713, 198);
            this.panel5.TabIndex = 1;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(140, 166);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(82, 25);
            this.Txt_Cantidad.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // Txt_CodigoProducto
            // 
            this.Txt_CodigoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoProducto.Location = new System.Drawing.Point(140, 68);
            this.Txt_CodigoProducto.Name = "Txt_CodigoProducto";
            this.Txt_CodigoProducto.Size = new System.Drawing.Size(560, 25);
            this.Txt_CodigoProducto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo de Producto";
            // 
            // Txt_PrecioProducto
            // 
            this.Txt_PrecioProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PrecioProducto.Location = new System.Drawing.Point(140, 115);
            this.Txt_PrecioProducto.Mask = "₡ 0000000";
            this.Txt_PrecioProducto.Name = "Txt_PrecioProducto";
            this.Txt_PrecioProducto.Size = new System.Drawing.Size(82, 25);
            this.Txt_PrecioProducto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de Pago";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(385, 15);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(315, 25);
            this.Txt_Descripcion.TabIndex = 6;
            // 
            // Cb_TipoPago
            // 
            this.Cb_TipoPago.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TipoPago.FormattingEnabled = true;
            this.Cb_TipoPago.Items.AddRange(new object[] {
            "01 - Efectivo",
            "02 - Tarjeta",
            "03 - Sinpe Movil",
            "04 - Otro"});
            this.Cb_TipoPago.Location = new System.Drawing.Point(119, 15);
            this.Cb_TipoPago.Name = "Cb_TipoPago";
            this.Cb_TipoPago.Size = new System.Drawing.Size(158, 25);
            this.Cb_TipoPago.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioProveedoresToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioProveedoresToolStripMenuItem
            // 
            this.inventarioProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.inventarioProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioProveedoresToolStripMenuItem.Image")));
            this.inventarioProveedoresToolStripMenuItem.Name = "inventarioProveedoresToolStripMenuItem";
            this.inventarioProveedoresToolStripMenuItem.Size = new System.Drawing.Size(187, 21);
            this.inventarioProveedoresToolStripMenuItem.Text = "Inventario / Proveedores";
            this.inventarioProveedoresToolStripMenuItem.Click += new System.EventHandler(this.inventarioProveedoresToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioToolStripMenuItem.Image")));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarAgregarUsuarioToolStripMenuItem1});
            this.seguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadToolStripMenuItem.Image")));
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // administrarAgregarUsuarioToolStripMenuItem1
            // 
            this.administrarAgregarUsuarioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("administrarAgregarUsuarioToolStripMenuItem1.Image")));
            this.administrarAgregarUsuarioToolStripMenuItem1.Name = "administrarAgregarUsuarioToolStripMenuItem1";
            this.administrarAgregarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(259, 22);
            this.administrarAgregarUsuarioToolStripMenuItem1.Text = "Administrar / Agregar Usuario";
            this.administrarAgregarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.administrarAgregarUsuarioToolStripMenuItem1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(33, 355);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 147);
            this.panel4.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(303, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Facturas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Honeydew;
            this.panel6.Controls.Add(this.Dgv_ProveedoresRegistrados);
            this.panel6.Location = new System.Drawing.Point(3, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(673, 115);
            this.panel6.TabIndex = 0;
            // 
            // Dgv_ProveedoresRegistrados
            // 
            this.Dgv_ProveedoresRegistrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv_ProveedoresRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ProveedoresRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_ProveedoresRegistrados.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Dgv_ProveedoresRegistrados.Location = new System.Drawing.Point(3, 3);
            this.Dgv_ProveedoresRegistrados.Name = "Dgv_ProveedoresRegistrados";
            this.Dgv_ProveedoresRegistrados.ReadOnly = true;
            this.Dgv_ProveedoresRegistrados.Size = new System.Drawing.Size(667, 109);
            this.Dgv_ProveedoresRegistrados.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(184, 508);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 184);
            this.panel7.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.Btn_CancelarCompra);
            this.panel9.Controls.Add(this.Btn_QuitarProducto);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.Btn_Facturar);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(4, 67);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 114);
            this.panel9.TabIndex = 17;
            // 
            // Btn_CancelarCompra
            // 
            this.Btn_CancelarCompra.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_CancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CancelarCompra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarCompra.Image")));
            this.Btn_CancelarCompra.Location = new System.Drawing.Point(282, 7);
            this.Btn_CancelarCompra.Name = "Btn_CancelarCompra";
            this.Btn_CancelarCompra.Size = new System.Drawing.Size(58, 58);
            this.Btn_CancelarCompra.TabIndex = 13;
            this.Btn_CancelarCompra.UseVisualStyleBackColor = false;
            this.Btn_CancelarCompra.Click += new System.EventHandler(this.Btn_CancelarCompra_Click);
            // 
            // Btn_QuitarProducto
            // 
            this.Btn_QuitarProducto.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_QuitarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_QuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_QuitarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_QuitarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_QuitarProducto.Image")));
            this.Btn_QuitarProducto.Location = new System.Drawing.Point(151, 7);
            this.Btn_QuitarProducto.Name = "Btn_QuitarProducto";
            this.Btn_QuitarProducto.Size = new System.Drawing.Size(58, 58);
            this.Btn_QuitarProducto.TabIndex = 12;
            this.Btn_QuitarProducto.UseVisualStyleBackColor = false;
            this.Btn_QuitarProducto.Click += new System.EventHandler(this.Btn_QuitarProducto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 34);
            this.label12.TabIndex = 11;
            this.label12.Text = "  Quitar \r\nProducto";
            // 
            // Btn_Facturar
            // 
            this.Btn_Facturar.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Facturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Facturar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Facturar.Image")));
            this.Btn_Facturar.Location = new System.Drawing.Point(26, 7);
            this.Btn_Facturar.Name = "Btn_Facturar";
            this.Btn_Facturar.Size = new System.Drawing.Size(58, 58);
            this.Btn_Facturar.TabIndex = 10;
            this.Btn_Facturar.UseVisualStyleBackColor = false;
            this.Btn_Facturar.Click += new System.EventHandler(this.Btn_Facturar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 34);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cancelar \r\n Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Facturar";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.Txt_TotalPagar);
            this.panel8.Controls.Add(this.Txt_SubTotal);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 58);
            this.panel8.TabIndex = 1;
            // 
            // Txt_TotalPagar
            // 
            this.Txt_TotalPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalPagar.Location = new System.Drawing.Point(283, 15);
            this.Txt_TotalPagar.Mask = "₡ 0000000";
            this.Txt_TotalPagar.Name = "Txt_TotalPagar";
            this.Txt_TotalPagar.Size = new System.Drawing.Size(82, 25);
            this.Txt_TotalPagar.TabIndex = 16;
            // 
            // Txt_SubTotal
            // 
            this.Txt_SubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SubTotal.Location = new System.Drawing.Point(69, 15);
            this.Txt_SubTotal.Mask = "₡ 0000000";
            this.Txt_SubTotal.Name = "Txt_SubTotal";
            this.Txt_SubTotal.Size = new System.Drawing.Size(82, 25);
            this.Txt_SubTotal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total a Pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subtotal";
            // 
            // Pb_Usuario
            // 
            this.Pb_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Usuario.Image")));
            this.Pb_Usuario.Location = new System.Drawing.Point(667, 31);
            this.Pb_Usuario.Name = "Pb_Usuario";
            this.Pb_Usuario.Size = new System.Drawing.Size(45, 47);
            this.Pb_Usuario.TabIndex = 16;
            this.Pb_Usuario.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(664, 81);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(34, 17);
            this.Lbl_Usuario.TabIndex = 15;
            this.Lbl_Usuario.Text = "user";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(658, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Log Out";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_CajaRegistradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 704);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Pb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CajaRegistradora";
            this.Load += new System.EventHandler(this.Frm_CajaRegistradora_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProveedoresRegistrados)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_CodigoP;
        private System.Windows.Forms.DateTimePicker Dtp_FechaCompra;
        private System.Windows.Forms.TextBox Txt_CodigoVenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_TipoPago;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.MaskedTextBox Txt_PrecioProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView Dgv_ProveedoresRegistrados;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox Txt_TotalPagar;
        private System.Windows.Forms.MaskedTextBox Txt_SubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Pb_Usuario;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_QuitarProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Facturar;
        private System.Windows.Forms.Button Btn_CancelarCompra;
        private System.Windows.Forms.ToolStripMenuItem inventarioProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarAgregarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Lbl_Usuario;
    }
}