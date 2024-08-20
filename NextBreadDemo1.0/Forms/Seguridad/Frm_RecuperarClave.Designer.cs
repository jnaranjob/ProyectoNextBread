namespace NextBreadDemo1._0.Forms.Seguridad
{
    partial class Frm_RecuperarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RecuperarClave));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Logearse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_CodigoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(152, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 163);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Txt_CodigoUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Btn_Logearse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 156);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Usuario";
            // 
            // Btn_Logearse
            // 
            this.Btn_Logearse.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Logearse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Logearse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Logearse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Logearse.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Logearse.Image")));
            this.Btn_Logearse.Location = new System.Drawing.Point(56, 66);
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
            this.label6.Location = new System.Drawing.Point(56, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Entrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 51);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 97);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_CodigoUsuario
            // 
            this.Txt_CodigoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoUsuario.Location = new System.Drawing.Point(3, 35);
            this.Txt_CodigoUsuario.Mask = "               0000";
            this.Txt_CodigoUsuario.Name = "Txt_CodigoUsuario";
            this.Txt_CodigoUsuario.Size = new System.Drawing.Size(148, 25);
            this.Txt_CodigoUsuario.TabIndex = 14;
            // 
            // Frm_RecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RecuperarClave";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Logearse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox Txt_CodigoUsuario;
    }
}