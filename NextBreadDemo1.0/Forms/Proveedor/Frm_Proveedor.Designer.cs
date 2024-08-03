namespace NextBreadDemo1._0.Forms.Proveedor
{
    partial class Frm_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor));
            this.Pb_Usuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.Cb_EstadoProveedor = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_AgregarProveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb_Usuario
            // 
            this.Pb_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Usuario.Image")));
            this.Pb_Usuario.Location = new System.Drawing.Point(743, 40);
            this.Pb_Usuario.Name = "Pb_Usuario";
            this.Pb_Usuario.Size = new System.Drawing.Size(45, 47);
            this.Pb_Usuario.TabIndex = 9;
            this.Pb_Usuario.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(740, 90);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Usuario.TabIndex = 8;
            this.Lbl_Usuario.Text = "admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 138);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Txt_NombreProveedor);
            this.panel3.Controls.Add(this.Cb_EstadoProveedor);
            this.panel3.Location = new System.Drawing.Point(180, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 132);
            this.panel3.TabIndex = 7;
            // 
            // Txt_NombreProveedor
            // 
            this.Txt_NombreProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreProveedor.Location = new System.Drawing.Point(6, 24);
            this.Txt_NombreProveedor.Name = "Txt_NombreProveedor";
            this.Txt_NombreProveedor.Size = new System.Drawing.Size(269, 25);
            this.Txt_NombreProveedor.TabIndex = 7;
            // 
            // Cb_EstadoProveedor
            // 
            this.Cb_EstadoProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_EstadoProveedor.FormattingEnabled = true;
            this.Cb_EstadoProveedor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cb_EstadoProveedor.Location = new System.Drawing.Point(6, 77);
            this.Cb_EstadoProveedor.Name = "Cb_EstadoProveedor";
            this.Cb_EstadoProveedor.Size = new System.Drawing.Size(135, 25);
            this.Cb_EstadoProveedor.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 132);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado del Proveedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarProductosToolStripMenuItem
            // 
            this.editarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.editarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarProductosToolStripMenuItem.Image")));
            this.editarProductosToolStripMenuItem.Name = "editarProductosToolStripMenuItem";
            this.editarProductosToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.editarProductosToolStripMenuItem.Text = "Editar Proveedores";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem1.Image")));
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(275, 22);
            this.administrarToolStripMenuItem1.Text = "Administrar / Editar Proveedores";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(489, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 251);
            this.panel6.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.Btn_Regresar);
            this.panel8.Location = new System.Drawing.Point(3, 132);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(220, 113);
            this.panel8.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "  Regresar\r\na Inventario";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.White;
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.Location = new System.Drawing.Point(80, 12);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(60, 58);
            this.Btn_Regresar.TabIndex = 11;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.Btn_AgregarProveedor);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.Btn_Limpiar);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 123);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "   Limpiar\r\nInformacion";
            // 
            // Btn_AgregarProveedor
            // 
            this.Btn_AgregarProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_AgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarProveedor.Image")));
            this.Btn_AgregarProveedor.Location = new System.Drawing.Point(20, 6);
            this.Btn_AgregarProveedor.Name = "Btn_AgregarProveedor";
            this.Btn_AgregarProveedor.Size = new System.Drawing.Size(58, 58);
            this.Btn_AgregarProveedor.TabIndex = 9;
            this.Btn_AgregarProveedor.UseVisualStyleBackColor = false;
            this.Btn_AgregarProveedor.Click += new System.EventHandler(this.Btn_AgregarProveedor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = " Agregar \r\nProveedor";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(133, 7);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(58, 58);
            this.Btn_Limpiar.TabIndex = 11;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Frm_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Usuario;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_NombreProveedor;
        private System.Windows.Forms.ComboBox Cb_EstadoProveedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_AgregarProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}