using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Avisos.Inventario
{
    public partial class Frm_ExcepcionCampoNull : Form
    {
        public Frm_ExcepcionCampoNull()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
