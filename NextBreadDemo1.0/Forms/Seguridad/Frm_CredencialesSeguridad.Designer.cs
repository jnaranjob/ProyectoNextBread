namespace NextBreadDemo1._0.Forms.Seguridad
{
    partial class Frm_CredencialesSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CredencialesSeguridad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Logearse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Ch_VerClave = new System.Windows.Forms.CheckBox();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(63, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 137);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Btn_Logearse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Ch_VerClave);
            this.panel3.Controls.Add(this.Txt_Clave);
            this.panel3.Controls.Add(this.Txt_Usuario);
            this.panel3.Location = new System.Drawing.Point(121, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 130);
            this.panel3.TabIndex = 7;
            // 
            // Btn_Logearse
            // 
            this.Btn_Logearse.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Logearse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logearse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logearse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Logearse.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logearse.Image")));
            this.Btn_Logearse.Location = new System.Drawing.Point(178, 24);
            this.Btn_Logearse.Name = "Btn_Logearse";
            this.Btn_Logearse.Size = new System.Drawing.Size(45, 58);
            this.Btn_Logearse.TabIndex = 13;
            this.Btn_Logearse.UseVisualStyleBackColor = false;
            this.Btn_Logearse.Click += new System.EventHandler(this.Btn_Logearse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Entrar";
            // 
            // Ch_VerClave
            // 
            this.Ch_VerClave.AutoSize = true;
            this.Ch_VerClave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ch_VerClave.Location = new System.Drawing.Point(6, 105);
            this.Ch_VerClave.Name = "Ch_VerClave";
            this.Ch_VerClave.Size = new System.Drawing.Size(82, 21);
            this.Ch_VerClave.TabIndex = 9;
            this.Ch_VerClave.Text = "Ver Clave";
            this.Ch_VerClave.UseVisualStyleBackColor = true;
            this.Ch_VerClave.CheckedChanged += new System.EventHandler(this.Ch_VerClave_CheckedChanged);
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave.Location = new System.Drawing.Point(6, 74);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.Size = new System.Drawing.Size(137, 25);
            this.Txt_Clave.TabIndex = 8;
            this.Txt_Clave.UseSystemPasswordChar = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(6, 24);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(137, 25);
            this.Txt_Usuario.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 130);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Por seguridad debera ingresas sus credenciales, si no cuenta \r\n                co" +
    "n permiso de tipo 3 no podra ingresar.";
            // 
            // Frm_CredencialesSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CredencialesSeguridad";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Logearse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Ch_VerClave;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}