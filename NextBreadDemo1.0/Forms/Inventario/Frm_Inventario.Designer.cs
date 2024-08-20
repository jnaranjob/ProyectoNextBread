namespace NextBreadDemo1._0.Forms.Inventario
{
    partial class Frm_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_CantidadProducto = new System.Windows.Forms.MaskedTextBox();
            this.Txt_ProveedorProducto = new System.Windows.Forms.TextBox();
            this.Txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.Txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.Txt_PrecioProducto = new System.Windows.Forms.MaskedTextBox();
            this.Cb_EstadoProducto = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_CodigoP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Pb_Usuario = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Dgv_ProveedoresRegistrados = new System.Windows.Forms.DataGridView();
            this.Btn_AgregarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_AsignarProveedor = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProveedoresRegistrados)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 269);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Txt_CantidadProducto);
            this.panel3.Controls.Add(this.Txt_ProveedorProducto);
            this.panel3.Controls.Add(this.Txt_CodigoProducto);
            this.panel3.Controls.Add(this.Txt_NombreProducto);
            this.panel3.Controls.Add(this.Txt_PrecioProducto);
            this.panel3.Controls.Add(this.Cb_EstadoProducto);
            this.panel3.Location = new System.Drawing.Point(180, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 261);
            this.panel3.TabIndex = 7;
            // 
            // Txt_CantidadProducto
            // 
            this.Txt_CantidadProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CantidadProducto.Location = new System.Drawing.Point(3, 189);
            this.Txt_CantidadProducto.Mask = "00000";
            this.Txt_CantidadProducto.Name = "Txt_CantidadProducto";
            this.Txt_CantidadProducto.Size = new System.Drawing.Size(63, 25);
            this.Txt_CantidadProducto.TabIndex = 12;
            // 
            // Txt_ProveedorProducto
            // 
            this.Txt_ProveedorProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_ProveedorProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ProveedorProducto.Location = new System.Drawing.Point(3, 229);
            this.Txt_ProveedorProducto.Name = "Txt_ProveedorProducto";
            this.Txt_ProveedorProducto.ReadOnly = true;
            this.Txt_ProveedorProducto.Size = new System.Drawing.Size(257, 25);
            this.Txt_ProveedorProducto.TabIndex = 11;
            // 
            // Txt_CodigoProducto
            // 
            this.Txt_CodigoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoProducto.Location = new System.Drawing.Point(3, 15);
            this.Txt_CodigoProducto.Name = "Txt_CodigoProducto";
            this.Txt_CodigoProducto.Size = new System.Drawing.Size(257, 25);
            this.Txt_CodigoProducto.TabIndex = 6;
            // 
            // Txt_NombreProducto
            // 
            this.Txt_NombreProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreProducto.Location = new System.Drawing.Point(3, 57);
            this.Txt_NombreProducto.Name = "Txt_NombreProducto";
            this.Txt_NombreProducto.Size = new System.Drawing.Size(257, 25);
            this.Txt_NombreProducto.TabIndex = 7;
            // 
            // Txt_PrecioProducto
            // 
            this.Txt_PrecioProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PrecioProducto.Location = new System.Drawing.Point(3, 102);
            this.Txt_PrecioProducto.Mask = "₡ 0000000";
            this.Txt_PrecioProducto.Name = "Txt_PrecioProducto";
            this.Txt_PrecioProducto.Size = new System.Drawing.Size(82, 25);
            this.Txt_PrecioProducto.TabIndex = 9;
            // 
            // Cb_EstadoProducto
            // 
            this.Cb_EstadoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_EstadoProducto.FormattingEnabled = true;
            this.Cb_EstadoProducto.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cb_EstadoProducto.Location = new System.Drawing.Point(3, 146);
            this.Cb_EstadoProducto.Name = "Cb_EstadoProducto";
            this.Cb_EstadoProducto.Size = new System.Drawing.Size(135, 25);
            this.Cb_EstadoProducto.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Lbl_CodigoP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 261);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Proveedor del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio Costo del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad en Stock";
            // 
            // Lbl_CodigoP
            // 
            this.Lbl_CodigoP.AutoSize = true;
            this.Lbl_CodigoP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoP.Location = new System.Drawing.Point(3, 18);
            this.Lbl_CodigoP.Name = "Lbl_CodigoP";
            this.Lbl_CodigoP.Size = new System.Drawing.Size(112, 17);
            this.Lbl_CodigoP.TabIndex = 0;
            this.Lbl_CodigoP.Text = "Codigo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado del Producto";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(711, 77);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Usuario.TabIndex = 6;
            this.Lbl_Usuario.Text = "admin";
            // 
            // Pb_Usuario
            // 
            this.Pb_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Usuario.Image")));
            this.Pb_Usuario.Location = new System.Drawing.Point(714, 27);
            this.Pb_Usuario.Name = "Pb_Usuario";
            this.Pb_Usuario.Size = new System.Drawing.Size(45, 47);
            this.Pb_Usuario.TabIndex = 7;
            this.Pb_Usuario.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(15, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 169);
            this.panel4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Proveedores Registrados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.Dgv_ProveedoresRegistrados);
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(673, 138);
            this.panel5.TabIndex = 0;
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
            this.Dgv_ProveedoresRegistrados.Size = new System.Drawing.Size(667, 132);
            this.Dgv_ProveedoresRegistrados.TabIndex = 0;
            // 
            // Btn_AgregarProducto
            // 
            this.Btn_AgregarProducto.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarProducto.Image")));
            this.Btn_AgregarProducto.Location = new System.Drawing.Point(20, 6);
            this.Btn_AgregarProducto.Name = "Btn_AgregarProducto";
            this.Btn_AgregarProducto.Size = new System.Drawing.Size(58, 58);
            this.Btn_AgregarProducto.TabIndex = 9;
            this.Btn_AgregarProducto.UseVisualStyleBackColor = false;
            this.Btn_AgregarProducto.Click += new System.EventHandler(this.Btn_AgregarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = " Agregar \r\nProducto";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(465, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 269);
            this.panel6.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.Btn_Regresar);
            this.panel8.Controls.Add(this.Btn_AsignarProveedor);
            this.panel8.Location = new System.Drawing.Point(115, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(105, 260);
            this.panel8.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "Regresar\r\n  a Caja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = " Asigar el\r\nProveedor";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.White;
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.Location = new System.Drawing.Point(23, 128);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(60, 58);
            this.Btn_Regresar.TabIndex = 11;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_AsignarProveedor
            // 
            this.Btn_AsignarProveedor.BackColor = System.Drawing.Color.White;
            this.Btn_AsignarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AsignarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AsignarProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AsignarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AsignarProveedor.Image")));
            this.Btn_AsignarProveedor.Location = new System.Drawing.Point(23, 5);
            this.Btn_AsignarProveedor.Name = "Btn_AsignarProveedor";
            this.Btn_AsignarProveedor.Size = new System.Drawing.Size(58, 58);
            this.Btn_AsignarProveedor.TabIndex = 12;
            this.Btn_AsignarProveedor.UseVisualStyleBackColor = false;
            this.Btn_AsignarProveedor.Click += new System.EventHandler(this.Btn_AsignarProveedor_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.Btn_AgregarProducto);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.Btn_Limpiar);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(106, 261);
            this.panel7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "   Limpiar\r\nInformacion";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(20, 129);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(58, 58);
            this.Btn_Limpiar.TabIndex = 11;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administrarToolStripMenuItem.Text = "Administrar ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProductosToolStripMenuItem,
            this.proveedoresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarProductosToolStripMenuItem
            // 
            this.editarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.editarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarProductosToolStripMenuItem.Image")));
            this.editarProductosToolStripMenuItem.Name = "editarProductosToolStripMenuItem";
            this.editarProductosToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.editarProductosToolStripMenuItem.Text = "Editar Productos";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem1.Image")));
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.administrarToolStripMenuItem1.Text = "Administrar / Editar Productos";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem1.Image")));
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(112, 21);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            this.agregarProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarProveedoresToolStripMenuItem.Image")));
            this.agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            this.agregarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores";
            this.agregarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedoresToolStripMenuItem_Click);
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 502);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Pb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Inventario";
            this.Text = "NextBread Inventario";
            this.Load += new System.EventHandler(this.Frm_Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ProveedoresRegistrados)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_CodigoP;
        private System.Windows.Forms.MaskedTextBox Txt_PrecioProducto;
        private System.Windows.Forms.ComboBox Cb_EstadoProducto;
        private System.Windows.Forms.TextBox Txt_NombreProducto;
        private System.Windows.Forms.TextBox Txt_CodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ProveedorProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox Txt_CantidadProducto;
        private System.Windows.Forms.PictureBox Pb_Usuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView Dgv_ProveedoresRegistrados;
        private System.Windows.Forms.Button Btn_AgregarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_AsignarProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedoresToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Lbl_Usuario;
    }
}