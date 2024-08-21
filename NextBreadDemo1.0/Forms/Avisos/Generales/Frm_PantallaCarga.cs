using NextBreadDemo1._0.Forms.Caja_Registradora;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Forms.Proveedor;
using NextBreadDemo1._0.Forms.Seguridad;
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

namespace NextBreadDemo1._0.Forms.Avisos.Generales
{
    public partial class Frm_PantallaCarga : Form
    {
        private string nombreUsuario;

        private IntUsuario moduloSeguridad;
        private Frm_CajaRegistradora frm_CajaRegistradora;
        private Frm_Inventario frm_Inventario;
        private Frm_EditarProductos frm_EditarProductos;
        private Frm_Proveedor frm_Proveedor;
        private Frm_EditarProveedor frm_EditarProveedor;
        private Frm_ModuloSeguridad frm_ModuloSeguridad;

        public Frm_PantallaCarga(string nombreUsuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            moduloSeguridad = new ModuloSeguridad();

            this.nombreUsuario = nombreUsuario;
        }

        public Frm_CajaRegistradora Frm_CajaRegistradora => frm_CajaRegistradora;
        public Frm_Inventario Frm_Inventario => frm_Inventario;
        public Frm_EditarProductos Frm_EditarProductos => frm_EditarProductos;
        public Frm_Proveedor Frm_Proveedor => frm_Proveedor;
        public Frm_EditarProveedor Frm_EditarProveedor => frm_EditarProveedor;
        public Frm_ModuloSeguridad Frm_ModuloSeguridad => frm_ModuloSeguridad;

        private async void Frm_PantallaCarga_Load(object sender, EventArgs e)
        {
            CerrarFormularios();
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(60);
                progressBar1.Value = i;
                Lbl_Carga.Text = $"Cargando... {i}%";
            }

            frm_CajaRegistradora = new Frm_CajaRegistradora();
            frm_Inventario = new Frm_Inventario();
            frm_EditarProductos = new Frm_EditarProductos();
            frm_Proveedor = new Frm_Proveedor();
            frm_EditarProveedor = new Frm_EditarProveedor();
            frm_ModuloSeguridad = new Frm_ModuloSeguridad();

            frm_CajaRegistradora.Lbl_Usuario.Text = nombreUsuario;
            frm_Inventario.Lbl_Usuario.Text = nombreUsuario;
            frm_EditarProductos.Lbl_Usuario.Text = nombreUsuario;
            frm_Proveedor.Lbl_Usuario.Text = nombreUsuario;
            frm_EditarProveedor.Lbl_Usuario.Text = nombreUsuario;
            frm_ModuloSeguridad.Lbl_Usuario.Text = nombreUsuario;

            frm_CajaRegistradora.Show();
            this.Hide();
            Frm_Login login = new Frm_Login();
            login.Close();
        }

        public void CerrarFormularios()
        {
            frm_CajaRegistradora?.Close();
            frm_Inventario?.Close();
            frm_EditarProductos?.Close();
            frm_Proveedor?.Close();
            frm_EditarProveedor?.Close();
            frm_ModuloSeguridad?.Close();
        }

    }

}
