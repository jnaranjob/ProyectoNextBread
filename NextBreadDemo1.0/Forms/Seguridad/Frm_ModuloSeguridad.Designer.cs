namespace NextBreadDemo1._0.Forms.Seguridad
{
    partial class Frm_ModuloSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModuloSeguridad));
            this.Pb_Usuario = new System.Windows.Forms.PictureBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cb_EstadoProducto = new System.Windows.Forms.ComboBox();
            this.Cb_Permisos = new System.Windows.Forms.ComboBox();
            this.Txt_CodigoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_LlenarUsuario = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Dgv_UsuariosRegistrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_UsuariosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Usuario
            // 
            this.Pb_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Usuario.Image")));
            this.Pb_Usuario.Location = new System.Drawing.Point(743, 25);
            this.Pb_Usuario.Name = "Pb_Usuario";
            this.Pb_Usuario.Size = new System.Drawing.Size(45, 47);
            this.Pb_Usuario.TabIndex = 18;
            this.Pb_Usuario.TabStop = false;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(740, 75);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Usuario.TabIndex = 17;
            this.Lbl_Usuario.Text = "admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 296);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Cb_EstadoProducto);
            this.panel3.Controls.Add(this.Cb_Permisos);
            this.panel3.Controls.Add(this.Txt_CodigoUsuario);
            this.panel3.Controls.Add(this.Txt_Clave);
            this.panel3.Controls.Add(this.Txt_Usuario);
            this.panel3.Location = new System.Drawing.Point(121, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 290);
            this.panel3.TabIndex = 7;
            // 
            // Cb_EstadoProducto
            // 
            this.Cb_EstadoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_EstadoProducto.FormattingEnabled = true;
            this.Cb_EstadoProducto.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cb_EstadoProducto.Location = new System.Drawing.Point(3, 245);
            this.Cb_EstadoProducto.Name = "Cb_EstadoProducto";
            this.Cb_EstadoProducto.Size = new System.Drawing.Size(135, 25);
            this.Cb_EstadoProducto.TabIndex = 22;
            // 
            // Cb_Permisos
            // 
            this.Cb_Permisos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Permisos.FormattingEnabled = true;
            this.Cb_Permisos.Items.AddRange(new object[] {
            "1 - Solo lectura y revision de informacion.",
            "2 - Solo lectura y administracion de caja.",
            "3 - Administracion total y revision de reportes."});
            this.Cb_Permisos.Location = new System.Drawing.Point(3, 185);
            this.Cb_Permisos.Name = "Cb_Permisos";
            this.Cb_Permisos.Size = new System.Drawing.Size(346, 25);
            this.Cb_Permisos.TabIndex = 21;
            // 
            // Txt_CodigoUsuario
            // 
            this.Txt_CodigoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoUsuario.Location = new System.Drawing.Point(3, 27);
            this.Txt_CodigoUsuario.Mask = "0000";
            this.Txt_CodigoUsuario.Name = "Txt_CodigoUsuario";
            this.Txt_CodigoUsuario.Size = new System.Drawing.Size(50, 25);
            this.Txt_CodigoUsuario.TabIndex = 20;
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave.Location = new System.Drawing.Point(3, 128);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(137, 25);
            this.Txt_Clave.TabIndex = 8;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(3, 75);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(137, 25);
            this.Txt_Usuario.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 290);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Permisos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(497, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 296);
            this.panel6.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.Btn_Regresar);
            this.panel8.Controls.Add(this.Btn_LlenarUsuario);
            this.panel8.Location = new System.Drawing.Point(115, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(105, 289);
            this.panel8.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "Regresar\r\n  a Caja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = " Llenar \r\nUsuario";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.White;
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.Location = new System.Drawing.Point(23, 165);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(60, 58);
            this.Btn_Regresar.TabIndex = 11;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_LlenarUsuario
            // 
            this.Btn_LlenarUsuario.BackColor = System.Drawing.Color.White;
            this.Btn_LlenarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LlenarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LlenarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_LlenarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LlenarUsuario.Image")));
            this.Btn_LlenarUsuario.Location = new System.Drawing.Point(25, 29);
            this.Btn_LlenarUsuario.Name = "Btn_LlenarUsuario";
            this.Btn_LlenarUsuario.Size = new System.Drawing.Size(58, 58);
            this.Btn_LlenarUsuario.TabIndex = 12;
            this.Btn_LlenarUsuario.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.Btn_AgregarUsuario);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.Btn_Limpiar);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(106, 290);
            this.panel7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "   Limpiar\r\nInformacion";
            // 
            // Btn_AgregarUsuario
            // 
            this.Btn_AgregarUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_AgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_AgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AgregarUsuario.Image")));
            this.Btn_AgregarUsuario.Location = new System.Drawing.Point(20, 30);
            this.Btn_AgregarUsuario.Name = "Btn_AgregarUsuario";
            this.Btn_AgregarUsuario.Size = new System.Drawing.Size(58, 58);
            this.Btn_AgregarUsuario.TabIndex = 9;
            this.Btn_AgregarUsuario.UseVisualStyleBackColor = false;
            this.Btn_AgregarUsuario.Click += new System.EventHandler(this.Btn_AgregarUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 51);
            this.label6.TabIndex = 6;
            this.label6.Text = " Agregar / \r\nActualizar\r\n Usuario";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(20, 166);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(58, 58);
            this.Btn_Limpiar.TabIndex = 11;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(10, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 169);
            this.panel4.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Usuarios Registrados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.Dgv_UsuariosRegistrados);
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(673, 138);
            this.panel5.TabIndex = 0;
            // 
            // Dgv_UsuariosRegistrados
            // 
            this.Dgv_UsuariosRegistrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Dgv_UsuariosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_UsuariosRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_UsuariosRegistrados.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Dgv_UsuariosRegistrados.Location = new System.Drawing.Point(3, 3);
            this.Dgv_UsuariosRegistrados.Name = "Dgv_UsuariosRegistrados";
            this.Dgv_UsuariosRegistrados.ReadOnly = true;
            this.Dgv_UsuariosRegistrados.Size = new System.Drawing.Size(667, 132);
            this.Dgv_UsuariosRegistrados.TabIndex = 0;
            // 
            // Frm_ModuloSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 505);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pb_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ModuloSeguridad";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Usuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_UsuariosRegistrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Txt_CodigoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Permisos;
        private System.Windows.Forms.ComboBox Cb_EstadoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_LlenarUsuario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_AgregarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView Dgv_UsuariosRegistrados;
        public System.Windows.Forms.Label Lbl_Usuario;
    }
}