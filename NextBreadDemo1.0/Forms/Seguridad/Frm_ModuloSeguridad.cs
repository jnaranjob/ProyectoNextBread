using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Entidades;
using NextBreadDemo1._0.Forms.Avisos;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Seguridad;
using NextBreadDemo1._0.Forms.Caja_Registradora;
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

namespace NextBreadDemo1._0.Forms.Seguridad
{
    public partial class Frm_ModuloSeguridad : Form
    {
        private IntUsuario moduloSeguridad;
        private static Frm_ExcepcionInterna excepcionInternaForm;
        private static Frm_ExcepcionInventario1 excepcionInventarioForm;
        private static Frm_ErrorCodigoUsuario errorCodigoUsuario;
        public Frm_ModuloSeguridad()
        {
            InitializeComponent();
            CargarDatosYConfigurarDGV();
            moduloSeguridad = new ModuloSeguridad();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void CargarDatosYConfigurarDGV()
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();

                using (SqlConnection connection = conexionBD.CrearNuevaConexion())
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        if (Dgv_UsuariosRegistrados != null)
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT IdUsuario, Nombre, Clave, Permiso, Estado FROM Usuario", connection))
                            {
                                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                                {
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    Dgv_UsuariosRegistrados.DataSource = dt;

                                    if (Dgv_UsuariosRegistrados.Columns.Contains("IdUsuario") &&
                                        Dgv_UsuariosRegistrados.Columns.Contains("Nombre") &&
                                        Dgv_UsuariosRegistrados.Columns.Contains("Clave") &&
                                        Dgv_UsuariosRegistrados.Columns.Contains("Permiso") &&
                                        Dgv_UsuariosRegistrados.Columns.Contains("Estado"))
                                    {
                                        Dgv_UsuariosRegistrados.Columns["IdUsuario"].HeaderText = "ID Usuario";
                                        Dgv_UsuariosRegistrados.Columns["Nombre"].HeaderText = "Nombre Usuario";
                                        Dgv_UsuariosRegistrados.Columns["Clave"].HeaderText = "Clave";
                                        Dgv_UsuariosRegistrados.Columns["Permiso"].HeaderText = "Permiso";
                                        Dgv_UsuariosRegistrados.Columns["Estado"].HeaderText = "Estado Actual";

                                        Dgv_UsuariosRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }
        private void MostrarExcepcionInterna()
        {
            excepcionInternaForm = new Frm_ExcepcionInterna();
            excepcionInternaForm.ShowDialog();
        }
        private void ErrorCodigoUsuario()
        {
            errorCodigoUsuario = new Frm_ErrorCodigoUsuario();
            errorCodigoUsuario.ShowDialog();
        }
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Frm_PantallaCarga pantallaCarga = (Frm_PantallaCarga)Application.OpenForms["Frm_PantallaCarga"];
            if (pantallaCarga != null)
            {
                Txt_CodigoUsuario.Clear();
                Txt_Usuario.Clear();
                Txt_Clave.Clear();
                Cb_Permisos.SelectedIndex = -1;
                Cb_EstadoProducto.SelectedIndex = -1;
                pantallaCarga.Frm_CajaRegistradora.Show();
                this.Hide();
            }
        }

        private void Btn_AgregarUsuario_Click(object sender, EventArgs e)
        {

            if (int.TryParse(Txt_CodigoUsuario.Text.Trim(), out int idUsuario))
            {
                string usuario = Txt_Usuario.Text;
                string clave = Txt_Clave.Text;
                int permiso;
                bool estado = true;

                string selectedItem = (string)Cb_Permisos.SelectedItem;

                if (selectedItem == "1 - Solo lectura y revision.")
                {
                    permiso = 1;
                }
                else if (selectedItem == "2 - Solo lectura y administracion de caja.")
                {
                    permiso = 2;
                }
                else
                {
                    permiso = 3;
                }

                string selectedItem2 = (string)Cb_EstadoProducto.SelectedItem;

                if (selectedItem2 == "Activo")
                {
                    estado = true;
                }
                else if (selectedItem2 == "Inactivo")
                {
                    estado = false;
                }

                moduloSeguridad.agregarUsuario(idUsuario, usuario, clave, permiso, estado);

                Txt_CodigoUsuario.Clear();
                Txt_Usuario.Clear();
                Txt_Clave.Clear();
                Cb_Permisos.SelectedIndex = -1;
                Cb_EstadoProducto.SelectedIndex = -1;
                CargarDatosYConfigurarDGV();
            }
            else
            {
                ErrorCodigoUsuario();
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_CodigoUsuario.Clear();
            Txt_Usuario.Clear();
            Txt_Clave.Clear();
            Cb_Permisos.SelectedIndex = -1;
            Cb_EstadoProducto.SelectedIndex = -1;
        }

        private void Btn_LlenarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_UsuariosRegistrados.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = Dgv_UsuariosRegistrados.SelectedRows[0];

                    if (selectedRow.Cells["IdUsuario"].Value != null &&
                        selectedRow.Cells["Nombre"].Value != null &&
                        selectedRow.Cells["Clave"].Value != null &&
                        selectedRow.Cells["Permiso"].Value != null &&
                        selectedRow.Cells["Estado"].Value != null)
                    {
                        string idUsuario = selectedRow.Cells["IdUsuario"].Value.ToString();
                        string nombreUsuario = selectedRow.Cells["Nombre"].Value.ToString();
                        string claveUsuario = selectedRow.Cells["Clave"].Value.ToString();
                        int permisoUsuario = Convert.ToInt32(selectedRow.Cells["Permiso"].Value);
                        bool estadoUsuario = Convert.ToBoolean(selectedRow.Cells["Estado"].Value);

                        Txt_CodigoUsuario.Text = idUsuario;
                        Txt_Usuario.Text = nombreUsuario;
                        Txt_Clave.Text = claveUsuario;

                        if (permisoUsuario == 1)
                        {
                            Cb_Permisos.SelectedItem = "1 - Solo lectura y revision de informacion.";
                        }
                        else if (permisoUsuario == 2)
                        {
                            Cb_Permisos.SelectedItem = "2 - Solo lectura y administracion de caja.";
                        }
                        else
                        {
                            Cb_Permisos.SelectedItem = "3 - Administracion total y revision de reportes.";
                        }

                        if (estadoUsuario)
                        {
                            Cb_EstadoProducto.SelectedItem = "Activo";
                        }
                        else
                        {
                            Cb_EstadoProducto.SelectedItem = "Inactivo";
                        }
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

        private void MostrarExcepcionInventario()
        {
            excepcionInventarioForm = new Frm_ExcepcionInventario1();
            excepcionInventarioForm.ShowDialog();
        }

        private void Btn_ActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txt_CodigoUsuario.Text.Trim(), out int codigo))
            {
                string usuario = Txt_Usuario.Text;
                string clave = Txt_Clave.Text;
                int permiso;
                bool estado = true;

                string selectedItem = (string)Cb_Permisos.SelectedItem;

                if (selectedItem == "1 - Solo lectura y revision.")
                {
                    permiso = 1;
                }
                else if (selectedItem == "2 - Solo lectura y administracion de caja.")
                {
                    permiso = 2;
                }
                else
                {
                    permiso = 3;
                }

                string selectedItem2 = (string)Cb_EstadoProducto.SelectedItem;

                if (selectedItem2 == "Activo")
                {
                    estado = true;
                }
                else if (selectedItem2 == "Inactivo")
                {
                    estado = false;
                }

                moduloSeguridad.editarUsuario(codigo, usuario, clave, permiso, estado);

                Txt_CodigoUsuario.Clear();
                Txt_Usuario.Clear();
                Txt_Clave.Clear();
                Cb_Permisos.SelectedIndex = -1;
                Cb_EstadoProducto.SelectedIndex = -1;
                CargarDatosYConfigurarDGV();

            }else
            {
                ErrorCodigoUsuario();
            }
        }

        private void Frm_ModuloSeguridad_Load(object sender, EventArgs e)
        {
            CargarDatosYConfigurarDGV();
        }
    }
}
