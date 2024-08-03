using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Inventario;
using NextBreadDemo1._0.Forms.Proveedor;
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
    public partial class Frm_Inventario : Form
    {
        private IntInventario _Inventario;
        private static Frm_ExcepcionInterna excepcionInternaForm;
        private static Frm_ExcepcionInventario1 excepcionInventarioForm;
        private static Frm_ExcepcionCampoNull procesoFallidoInventario;

        public Frm_Inventario()
        {
            InitializeComponent();
            CargarDatosYConfigurarDGV();
            _Inventario = new ModuloInventario();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {

        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_EditarProductos newForm = new Frm_EditarProductos();
            newForm.Show();
            this.Hide();
        }

        private void CargarDatosYConfigurarDGV()
        {
            try
            {
                if (ConexionBD.Instancia != null)
                {
                    ConexionBD.Instancia.AbrirConexion();

                    if (ConexionBD.Instancia.GetConnection().State == System.Data.ConnectionState.Open)
                    {
                        if (Dgv_ProveedoresRegistrados != null)
                        {
                            SqlCommand cmd = new SqlCommand("SELECT IdProveedor, Nombre, Estado FROM Proveedor", ConexionBD.Instancia.GetConnection());
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
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
                else
                {
                    MostrarExcepcionInterna();
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcionInterna();
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
            }
            finally
            {
                if (ConexionBD.Instancia != null)
                {
                    ConexionBD.Instancia.CerrarConexion();
                }
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

        private void Btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                long codigoP = long.Parse(Txt_CodigoProducto.Text);
                if (Txt_NombreProducto.Text == "" || (string)Cb_EstadoProducto.SelectedItem == null) { 
                    MostrarProcesoFallidoInventario(); 
                    return; 
                } else
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

                    _Inventario.agregarProducto(codigoP, nombre, precioCosto, cantidad, nombreProveedor, estado, nombreUsuario);
                    Txt_CodigoProducto.Clear();
                    Txt_NombreProducto.Clear();
                    Txt_PrecioProducto.Clear();
                    Txt_CantidadProducto.Clear();
                    Txt_ProveedorProducto.Clear();
                    Txt_CantidadProducto.Focus();
                }



            } catch (Exception ex)
            {
                MostrarProcesoFallidoInventario();
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
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
        private void MostrarProcesoFallidoInventario()
        {
            procesoFallidoInventario = new Frm_ExcepcionCampoNull();
            procesoFallidoInventario.ShowDialog();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_CodigoProducto.Clear();
            Txt_NombreProducto.Clear();
            Txt_PrecioProducto.Clear();
            Txt_CantidadProducto.Clear();
            Txt_ProveedorProducto.Clear();

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Proveedor newForm = new Frm_Proveedor();
            newForm.Show();
            this.Hide();
        }
    }
}
