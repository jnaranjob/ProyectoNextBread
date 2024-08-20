using NextBreadDemo1._0.Entidades;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Inventario;
using NextBreadDemo1._0.Forms.Caja_Registradora;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Interfaces;
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

namespace NextBreadDemo1._0.Forms.Proveedor
{
    public partial class Frm_Proveedor : Form
    {
        private IntProveedor _Proveedor;
        private IntUsuario moduloSeguridad;
        private static Frm_ExcepcionCampoNull procesoFallidoInventario;
        public Frm_Proveedor()
        {
            InitializeComponent();
            _Proveedor = new ModuloProveedor();
            moduloSeguridad = new ModuloSeguridad();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Inventario.Show();
                this.Hide();
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_NombreProveedor.Clear();
            Cb_EstadoProveedor.SelectedIndex = -1;
        }

        private void Btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = Txt_NombreProveedor.Text;
                Boolean estado = true;
                string nombreUsuario = Lbl_Usuario.Text;

                if (Txt_NombreProveedor.Text == "" || (string)Cb_EstadoProveedor.SelectedItem == null)
                {
                    MostrarProcesoFallido();
                    return;
                }

                string selectedItem = (string)Cb_EstadoProveedor.SelectedItem;

                if (selectedItem == "Activo")
                {
                    estado = true;
                }
                else if (selectedItem == "Inactivo")
                {
                    estado = false;
                }

                _Proveedor.agregarProveedor(nombre, estado, nombreUsuario);
                Txt_NombreProveedor.Clear();
                Txt_NombreProveedor.Focus();
            }
            catch (Exception)
            {
                MostrarProcesoFallido();
            }
        }

        private void MostrarProcesoFallido()
        {
            procesoFallidoInventario = new Frm_ExcepcionCampoNull();
            procesoFallidoInventario.ShowDialog();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_EditarProveedor.Show();
                this.Hide();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                Txt_NombreProveedor.Clear();
                Cb_EstadoProveedor.SelectedIndex = -1;
                pantallaCarga.Frm_CajaRegistradora.Show();
                this.Hide();
            }
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            permisos();
        }

        private void permisos()
        {
            Boolean tipoPermiso = moduloSeguridad.validarPermiso(Lbl_Usuario.Text);
            if (tipoPermiso == false)
            {
                Txt_NombreProveedor.Enabled = false;
                Cb_EstadoProveedor.Enabled = false;
                Btn_AgregarProveedor.Enabled = false;
                Btn_Limpiar.Enabled = false;
            }
        }

    }
}
