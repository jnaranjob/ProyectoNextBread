using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Avisos.Generales
{
    public partial class Frm_ProcesoFallido : Form
    {
        public Frm_ProcesoFallido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_ProcesoFallido_Load(object sender, EventArgs e)
        {

        }
    }
}
