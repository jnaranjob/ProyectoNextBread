using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Reporte
{
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.detalleFacturaTableAdapter.Fill(this.dataSet1.DetalleFactura);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

