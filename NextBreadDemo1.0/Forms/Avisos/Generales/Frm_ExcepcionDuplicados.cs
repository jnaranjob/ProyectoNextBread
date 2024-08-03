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
    public partial class Frm_ExcepcionDuplicados : Form
    {
        public Frm_ExcepcionDuplicados()
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
