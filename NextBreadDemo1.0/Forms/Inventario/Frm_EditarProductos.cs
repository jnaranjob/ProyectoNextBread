using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Inventario;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Forms.Inventario
{
    public partial class Frm_EditarProductos : Form
    {
        private IntInventario _Inventario;
        private IntUsuario moduloSeguridad;
        private static Frm_ExcepcionInterna excepcionInternaForm;
        private static Frm_ExcepcionInventario1 excepcionInventarioForm;
        private static Frm_ExcepcionCampoNull procesoFallidoInventario;
        private static Frm_ProductoInactivo productoInactivo;
        private DataTable dtOriginal;

        public Frm_EditarProductos()
        {
            InitializeComponent();
            CargarDatosYConfigurarDGV();
            CargarDatosYConfigurarDGVProveedores();
            _Inventario = new ModuloInventario();
            moduloSeguridad = new ModuloSeguridad();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Frm_EditarProductos_Load(object sender, EventArgs e)
        {
            permisos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dgv_ProductosRegistrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Frm_BuscarProducto newForm = new Frm_BuscarProducto(this);
            newForm.Show();
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
                        if (Dgv_ProductosRegistrados != null)
                        {
                            string query = @"SELECT i.CodigoProducto, i.Nombre AS Nombre, i.Estado, i.Precio, i.Cantidad, p.Nombre AS ""Nombre Proveedor""
                                     FROM Inventario i
                                     JOIN Proveedor p ON i.IdProveedor = p.IdProveedor";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                                {
                                    dtOriginal = new DataTable();
                                    da.Fill(dtOriginal);
                                    Dgv_ProductosRegistrados.DataSource = dtOriginal;

                                    if (Dgv_ProductosRegistrados.Columns.Contains("CodigoProducto") &&
                                        Dgv_ProductosRegistrados.Columns.Contains("Nombre") &&
                                        Dgv_ProductosRegistrados.Columns.Contains("Estado") &&
                                        Dgv_ProductosRegistrados.Columns.Contains("Precio") &&
                                        Dgv_ProductosRegistrados.Columns.Contains("Cantidad") &&
                                        Dgv_ProductosRegistrados.Columns.Contains("Nombre"))
                                    {
                                        Dgv_ProductosRegistrados.Columns["CodigoProducto"].HeaderText = "Codigo de Barras";
                                        Dgv_ProductosRegistrados.Columns["Nombre"].HeaderText = "Nombre";
                                        Dgv_ProductosRegistrados.Columns["Estado"].HeaderText = "Estado del Producto";
                                        Dgv_ProductosRegistrados.Columns["Precio"].HeaderText = "Precio Costo";
                                        Dgv_ProductosRegistrados.Columns["Cantidad"].HeaderText = "Cantidad en Stock";
                                        Dgv_ProductosRegistrados.Columns["Nombre"].HeaderText = "Proveedor Actual del Producto";

                                        Dgv_ProductosRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
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

        private void Btn_AsignarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_ProductosRegistrados.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Dgv_ProductosRegistrados.SelectedRows[0];

                    if (selectedRow.Cells["CodigoProducto"].Value != null)
                    {
                        string codigoProducto = selectedRow.Cells["CodigoProducto"].Value.ToString();
                        string nombreProducto = selectedRow.Cells["Nombre"].Value.ToString();
                        bool estado = Convert.ToBoolean(selectedRow.Cells["Estado"].Value);
                        decimal precioDecimal = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);
                        string precio = precioDecimal.ToString("0.##");
                        string cantidad = selectedRow.Cells["Cantidad"].Value.ToString();
                        string nombreProveedor = selectedRow.Cells["Nombre Proveedor"].Value.ToString();

                        Txt_CodigoProducto.Text = codigoProducto;
                        Txt_NombreProducto.Text = nombreProducto;
                        Cb_EstadoProducto.SelectedItem = estado ? "Activo" : "Inactivo";
                        Txt_PrecioProducto.Text = precio;
                        Txt_CantidadProducto.Text = cantidad;
                        Txt_ProveedorProducto.Text = nombreProveedor;
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
        public void FiltrarDatos(string criterio)
        {
            if (dtOriginal != null && dtOriginal.Rows.Count > 0)
            {
                try
                {
                    DataView dv = new DataView(dtOriginal);
                    dv.RowFilter = $"CodigoProducto LIKE '%{criterio}%' OR Nombre LIKE '%{criterio}%'";
                    Dgv_ProductosRegistrados.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay datos disponibles para filtrar.");
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_CodigoProducto.Clear();
            Txt_NombreProducto.Clear();
            Txt_PrecioProducto.Clear();
            Cb_EstadoProducto.SelectedIndex = -1;
            Txt_CantidadProducto.Clear();
            Txt_ProveedorProducto.Clear();
        }

        private void Btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {

                long codigoP = long.Parse(Txt_CodigoProducto.Text);
                if (Txt_NombreProducto.Text == "" || (string)Cb_EstadoProducto.SelectedItem == null)
                {
                    MostrarProcesoFallidoInventario();
                    return;
                }
                else
                {

                    string nombre = Txt_NombreProducto.Text;
                    string precio = Regex.Replace(Txt_PrecioProducto.Text, @"[^\d]", "");
                    int precioCosto = int.Parse(precio);
                    int cantidad = int.Parse(Txt_CantidadProducto.Text);
                    string nombreProveedor = Txt_ProveedorProducto.Text;
                    string nombreUsuario = Lbl_Usuario.Text;
                    Boolean estado = true;

                    string selectedItem = (string)Cb_EstadoProducto.SelectedItem;

                    if (selectedItem == "Activo")
                    {
                        estado = true;
                    }
                    else if (selectedItem == "Inactivo")
                    {
                        estado = false;

                    }

                    _Inventario.editarProducto(codigoP, nombre, precioCosto, cantidad, nombreProveedor, estado, nombreUsuario);
                    Txt_CodigoProducto.Clear();
                    Txt_NombreProducto.Clear();
                    Txt_PrecioProducto.Clear();
                    Txt_CantidadProducto.Clear();
                    Txt_ProveedorProducto.Clear();
                    Cb_EstadoProducto.SelectedIndex = -1;
                    Txt_NombreProducto.Focus();
                    CargarDatosYConfigurarDGV();
                }

            }
            catch (Exception)
            {
                MostrarProcesoFallidoInventario();
            }
        }

        private void MostrarProcesoFallidoInventario()
        {
            procesoFallidoInventario = new Frm_ExcepcionCampoNull();
            procesoFallidoInventario.ShowDialog();
        }

        private void MostrarProductoInactivo()
        {
            productoInactivo = new Frm_ProductoInactivo();
            productoInactivo.ShowDialog();
        }

        private void Txt_ProveedorProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarDatosYConfigurarDGVProveedores()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_ProveedoresRegistrados.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Dgv_ProveedoresRegistrados.SelectedRows[0];

                    if (selectedRow.Cells["Nombre"].Value != null)
                    {
                        string nombreProveedor = selectedRow.Cells["Nombre"].Value.ToString();

                        Txt_ProveedorProducto.Text = nombreProveedor;
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

        private void Cb_EstadoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)Cb_EstadoProducto.SelectedItem;

            if (selectedItem == "Inactivo")
            {
                MostrarProductoInactivo();
            }
        }
        private void permisos()
        {
            Boolean tipoPermiso = moduloSeguridad.validarPermiso(Lbl_Usuario.Text);
            if (tipoPermiso == false)
            {
                Txt_CodigoProducto.Enabled = false;
                Txt_NombreProducto.Enabled = false;
                Txt_PrecioProducto.Enabled = false;
                Txt_CantidadProducto.Enabled = false;
                Txt_ProveedorProducto.Enabled = false;
                Cb_EstadoProducto.Enabled = false;
                Btn_AgregarProducto.Enabled = false;
                Btn_Limpiar.Enabled = false;
                Btn_AsignarProveedor.Enabled = false;
                button1.Enabled = false;
            }
        }

    }
}
