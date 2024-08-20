using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Seguridad;
using NextBreadDemo1._0.Forms.Caja_Registradora;
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
    public partial class Frm_CredencialesSeguridad : Form
    {
        private static Frm_ErrorLoginUsuario errorLoginForm;
        private static Frm_ErrorLoginClave errorClaveForm;
        private static Frm_PermisosInsuficientes errorUsuarioPermiso;

        public Frm_CredencialesSeguridad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Logearse_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Usuario.Text;
            string clave = Txt_Clave.Text;

            validarCredenciales(nombre, clave);
        }

        private void Ch_VerClave_CheckedChanged(object sender, EventArgs e)
        {
            if (Ch_VerClave.Checked)
            {
                Txt_Clave.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_Clave.UseSystemPasswordChar = true;
            }
        }
        private void validarCredenciales(string nombre, string clave)
        {

            ConexionBD.Instancia.AbrirConexion();
            string queryDB = "SELECT Clave, Permiso FROM Usuario WHERE Nombre COLLATE Latin1_General_BIN = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
            {
                DBSQL.Parameters.AddWithValue("@Nombre", nombre);

                using (SqlDataReader reader = DBSQL.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string claveDB = reader.GetString(0);
                        int permiso = reader.GetInt32(1);

                        if (permiso == 1 || permiso == 2)
                        {
                            ErrorUsuarioPermiso();
                        }
                        else if (claveDB == clave)
                        {
                            Frm_ModuloSeguridad newForm = new Frm_ModuloSeguridad();
                            newForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            ErrorLoginClave();
                        }
                    }
                    else
                    {
                        ErrorLoginUsuarioForm();
                    }
                }

            }
        }
        private void ErrorLoginUsuarioForm()
        {
            errorLoginForm = new Frm_ErrorLoginUsuario();
            errorLoginForm.ShowDialog();
        }

        private void ErrorLoginClave()
        {
            errorClaveForm = new Frm_ErrorLoginClave();
            errorClaveForm.ShowDialog();
        }
        private void ErrorUsuarioPermiso()
        {
            errorUsuarioPermiso = new Frm_PermisosInsuficientes();
            errorUsuarioPermiso.ShowDialog();
        }

    }
}
