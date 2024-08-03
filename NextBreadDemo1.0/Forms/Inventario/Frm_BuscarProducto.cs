using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Inventario
{
    public partial class Frm_BuscarProducto : Form
    {

        private Frm_EditarProductos frmEditarProductos;


        public Frm_BuscarProducto(Frm_EditarProductos frmEditarProductos)
        {
            InitializeComponent();
            this.frmEditarProductos = frmEditarProductos;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void Frm_BuscarProducto_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditarProductos.CargarDatosYConfigurarDGV();
            this.Hide();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

            string criterio = Txt_CodigoProducto.Text.Trim();

            if (!string.IsNullOrEmpty(criterio))
            {
                // Filtrar datos en el DataGridView del formulario de edición
                frmEditarProductos.FiltrarDatos(criterio);
            }

        }
    }
}
