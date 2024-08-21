using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Caja_Registradora;
using NextBreadDemo1._0.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Seguridad
{
    public partial class Frm_Login : Form
    {
        private ModuloSeguridad moduloSeguridad;


        public Frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            moduloSeguridad = new ModuloSeguridad();
            moduloSeguridad.OnLoginSuccessful += HandleLoginSuccessful;
        }

        private void Ch_VerClave_CheckedChanged(object sender, EventArgs e)
        {

            if (Ch_VerClave.Checked)
            {
                Txt_Clave.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Clave.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Frm_RecuperarClave newForm = new Frm_RecuperarClave();
            newForm.Show();
        }

        private void Btn_Logearse_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Txt_Usuario.Text;
                string clave = Txt_Clave.Text;

                moduloSeguridad.validarCredenciales(nombre, clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleLoginSuccessful()
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Frm_PantallaCarga)
                {
                    form.Close();
                    break;
                }
            }

            Frm_PantallaCarga pantallaCarga = new Frm_PantallaCarga(Txt_Usuario.Text);
            pantallaCarga.Show();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}

