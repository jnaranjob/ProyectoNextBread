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

        public Frm_EditarProveedor()
        {
            InitializeComponent();
            CargarDatosYConfigurarDGV();
            _Proveedor = new ModuloProveedor();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Frm_Proveedor newForm = new Frm_Proveedor();
            newForm.Show();
            this.Hide();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_NombreProveedor.Clear();
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
                        bool estado = Convert.ToBoolean(selectedRow.Cells["Estado"].Value);

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

                _Proveedor.editarProveedor(nombre, estado, nombreUsuario);
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
    }
}
