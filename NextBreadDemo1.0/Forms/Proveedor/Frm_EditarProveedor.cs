using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Inventario;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Interfaces;
using NextBreadDemo1._0.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Proveedor
{
    public partial class Frm_EditarProveedor : Form
    {

        private static Frm_ExcepcionInterna excepcionInternaForm;
        private static Frm_ExcepcionInventario1 excepcionInventarioForm;
        private static Frm_ExcepcionCampoNull procesoFallidoInventario;
        private IntProveedor _Proveedor;
        private IntUsuario moduloSeguridad;

        public Frm_EditarProveedor()
        {
            InitializeComponent();
            CargarDatosYConfigurarDGV();
            _Proveedor = new ModuloProveedor();
            moduloSeguridad = new ModuloSeguridad();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                pantallaCarga.Frm_Proveedor.Show();
                this.Hide();
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Codigo.Clear();
            Txt_NombreProveedor.Clear();
            Cb_EstadoProveedor.SelectedIndex = -1;
        }

        public void CargarDatosYConfigurarDGV()
        {
            try
            {

                ConexionBD conexionBD = new ConexionBD();

                using (SqlConnection connection = conexionBD.CrearNuevaConexion())
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        if (Dgv_ProveedoresRegistrados != null)
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT IdProveedor, Nombre, Estado FROM Proveedor", connection))
                            {
                                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                                {
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    Dgv_ProveedoresRegistrados.DataSource = dt;

                                    if (Dgv_ProveedoresRegistrados.Columns.Contains("IdProveedor") &&
                                        Dgv_ProveedoresRegistrados.Columns.Contains("Nombre") &&
                                        Dgv_ProveedoresRegistrados.Columns.Contains("Estado"))
                                    {
                                        Dgv_ProveedoresRegistrados.Columns["IdProveedor"].HeaderText = "ID Proveedor";
                                        Dgv_ProveedoresRegistrados.Columns["Nombre"].HeaderText = "Nombre Proveedor";
                                        Dgv_ProveedoresRegistrados.Columns["Estado"].HeaderText = "Estado Actual Proveedor";

                                        Dgv_ProveedoresRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                    }
                                    else
                                    {
                                        MostrarExcepcionInterna();
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MostrarExcepcionInterna();
                            return;
                        }
                    }
                    else
                    {
                        MostrarExcepcionInterna();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcionInterna();
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }

        private void Btn_AsignarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_ProveedoresRegistrados.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Dgv_ProveedoresRegistrados.SelectedRows[0];

                    if (selectedRow.Cells["Nombre"].Value != null)
                    {
                        string codigo = selectedRow.Cells["IdProveedor"].Value.ToString();
                        string nombreProveedor = selectedRow.Cells["Nombre"].Value.ToString();
                        bool estado = Convert.ToBoolean(selectedRow.Cells["Estado"].Value);

                        Txt_Codigo.Text = codigo;
                        Cb_EstadoProveedor.SelectedItem = estado ? "Activo" : "Inactivo";
                        Txt_NombreProveedor.Text = nombreProveedor;
                    }
                    else
                    {
                        MostrarExcepcionInventario();
                    }
                }
                else
                {
                    MostrarExcepcionInventario();
                }
            }
            catch (Exception)
            {
                MostrarExcepcionInventario();
            }
        }

        private void MostrarExcepcionInterna()
        {
            excepcionInternaForm = new Frm_ExcepcionInterna();
            excepcionInternaForm.ShowDialog();
        }
        private void MostrarExcepcionInventario()
        {
            excepcionInventarioForm = new Frm_ExcepcionInventario1();
            excepcionInventarioForm.ShowDialog();
        }

        private void Btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(Txt_Codigo.Text);
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

                _Proveedor.editarProveedor(codigo, nombre, estado, nombreUsuario);
                Txt_NombreProveedor.Clear();
                Cb_EstadoProveedor.SelectedIndex = -1;
                Txt_NombreProveedor.Focus();
                CargarDatosYConfigurarDGV();
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

        private void Frm_EditarProveedor_Load(object sender, EventArgs e)
        {
            permisos();
            CargarDatosYConfigurarDGV();
        }

        private void permisos()
        {
            int tipoPermiso = moduloSeguridad.validarPermiso(Lbl_Usuario.Text);
            if (tipoPermiso == 1 || tipoPermiso == 2)
            {
                Txt_Codigo.Enabled = false;
                Txt_NombreProveedor.Enabled = false;
                Cb_EstadoProveedor.Enabled = false;

                Btn_AgregarProveedor.Enabled = false;
                Btn_Limpiar.Enabled = false;
                Btn_AsignarProveedor.Enabled = false;
            }
        }

    }
}
