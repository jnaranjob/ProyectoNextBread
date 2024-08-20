using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Forms.Proveedor;
using NextBreadDemo1._0.Forms.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Caja_Registradora
{
    public partial class Frm_CajaRegistradora : Form
    {
        public Frm_CajaRegistradora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Facturar_Click(object sender, EventArgs e)
        {

        }
        private void inventarioProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Inventario.Show();
                this.Hide();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Proveedor.Show();
                this.Hide();
            }
        }

        private void administrarAgregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_CredencialesSeguridad newForm = new Frm_CredencialesSeguridad();
            newForm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Frm_Login newForm = new Frm_Login();
            newForm.Show();
            this.Hide();
        }
    }
}
