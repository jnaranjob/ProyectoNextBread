using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
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
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de usuario válido de 4 dígitos.");
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
    }
}
