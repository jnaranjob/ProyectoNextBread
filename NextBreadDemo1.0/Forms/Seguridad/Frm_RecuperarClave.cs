using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Caja_Registradora;
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
    public partial class Frm_RecuperarClave : Form
    {
        public Frm_RecuperarClave()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Logearse_Click(object sender, EventArgs e)
        {
            Frm_CajaRegistradora newForm = new Frm_CajaRegistradora();
            newForm.Show();
            this.Hide();
        }
    }
}
