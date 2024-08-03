namespace NextBreadDemo1._0.Forms.Inventario
{
    partial class Frm_BuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_CodigoProducto = new System.Windows.Forms.TextBox();
            this.Lbl_CodigoP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 206);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Btn_Buscar);
            this.panel2.Controls.Add(this.Txt_CodigoProducto);
            this.panel2.Controls.Add(this.Lbl_CodigoP);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 199);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "  Cerrar \r\nBuscador";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(192, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 58);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 34);
            this.label10.TabIndex = 19;
            this.label10.Text = "  Buscar \r\nProducto";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.White;
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(54, 82);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(60, 58);
            this.Btn_Buscar.TabIndex = 18;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_CodigoProducto
            // 
            this.Txt_CodigoProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoProducto.Location = new System.Drawing.Point(21, 51);
            this.Txt_CodigoProducto.Name = "Txt_CodigoProducto";
            this.Txt_CodigoProducto.Size = new System.Drawing.Size(257, 25);
            this.Txt_CodigoProducto.TabIndex = 8;
            // 
            // Lbl_CodigoP
            // 
            this.Lbl_CodigoP.AutoSize = true;
            this.Lbl_CodigoP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoP.Location = new System.Drawing.Point(51, 31);
            this.Lbl_CodigoP.Name = "Lbl_CodigoP";
            this.Lbl_CodigoP.Size = new System.Drawing.Size(201, 17);
            this.Lbl_CodigoP.TabIndex = 7;
            this.Lbl_CodigoP.Text = "Nombre o Codigo del Producto";
            // 
            // Frm_BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 232);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_BuscarProducto";
            this.Text = "Next Bread Buscar Producto";
            this.Load += new System.EventHandler(this.Frm_BuscarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_CodigoProducto;
        private System.Windows.Forms.Label Lbl_CodigoP;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}