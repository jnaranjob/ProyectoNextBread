using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Seguridad;
using NextBreadDemo1._0.Forms.Caja_Registradora;
using NextBreadDemo1._0.Forms.Seguridad;
using NextBreadDemo1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0.Servicios
{
    public class ModuloSeguridad : IntUsuario
    {
        private static Frm_ErrorLoginUsuario errorLoginForm;
        private static Frm_ErrorLoginClave errorClaveForm;
        private static Frm_ErrorUsuarioDesactivado errorUsuarioDesactivado;
        private static Frm_UsuarioDuplicado errorUsuarioDuplicado;
        private static Frm_ProcesoExitoso procesoExitosoForm;
        private static Frm_ProcesoFallido procesoFallidoForm;

        public delegate void LoginSuccessfulHandler();
        public event LoginSuccessfulHandler OnLoginSuccessful;

        public ModuloSeguridad()
        {
        }

        void IntUsuario.agregarUsuario(int codigo, string nombre, string clave, int permiso, Boolean estado)
        {
            try
            {
                ConexionBD conexionBD = ConexionBD.Instancia;
                conexionBD.AbrirConexion();

                using (SqlConnection connection = conexionBD.CrearNuevaConexion())
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Usuario WHERE IdUsuario = @Codigo OR Nombre = @Nombre";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Codigo", codigo);
                        checkCmd.Parameters.AddWithValue("@Nombre", nombre);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            ErrorUsuarioDuplicado();
                            return;
                        }
                    }

                    string queryDB = "INSERT INTO Usuario (IdUsuario, Nombre, Clave, Permiso, Estado) " +
                                     "VALUES (@Codigo, @Nombre, @Clave, @Permiso, @Estado)";
                    using (SqlCommand DBSQL = new SqlCommand(queryDB, connection))
                    {
                        DBSQL.Parameters.AddWithValue("@Codigo", codigo);
                        DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                        DBSQL.Parameters.AddWithValue("@Clave", clave);
                        DBSQL.Parameters.AddWithValue("@Permiso", permiso);
                        DBSQL.Parameters.AddWithValue("@Estado", estado);

                        DBSQL.ExecuteNonQuery();
                        MostrarProcesoExitoso();
                    }
                }
            }
            catch
            {
                MostrarProcesoFallido();
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }

        void IntUsuario.desactivarUsuario(string nombre, bool estado)
        {

            string queryDB = "UPDATE Usuarios SET Estado = @Estado WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            {

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Estado", estado);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }

        }

        void IntUsuario.editarUsuario(string nombre, string clave, int permiso)
        {
            string queryDB = "UPDATE Usuarios SET Clave = @Clave, Permiso = @Permiso WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            {

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Clave", clave);
                DBSQL.Parameters.AddWithValue("@Permiso", permiso);

                DBSQL.ExecuteNonQuery();

            }

        }
        bool IntUsuario.validarPermiso(string nombre)
        {
            int permiso = permisoActual(nombre);
            Boolean comportamiento = false;

            if (permiso == 1)
            {
                comportamiento = false;
            }
            if (permiso == 2)
            {
                comportamiento = false;
            }
            if (permiso == 3)
            {
                comportamiento = true;
            }
            return comportamiento;
        }

        private int permisoActual(string nombre)
        {
            ConexionBD conexionBD = new ConexionBD();

            try
            {
                using (SqlConnection connection = conexionBD.CrearNuevaConexion())
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT Permiso FROM Usuario WHERE Nombre = @Nombre", connection))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", nombre);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return reader.GetInt32(0);
                                }
                                else
                                {
                                    throw new Exception("Usuario no encontrado.");
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo abrir la conexión a la base de datos.");
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void validarCredenciales(string nombre, string clave)
        {
            ConexionBD.Instancia.AbrirConexion();
            string queryDB = "SELECT Clave, Estado FROM Usuario WHERE Nombre COLLATE Latin1_General_BIN = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
            {
                DBSQL.Parameters.AddWithValue("@Nombre", nombre);

                using (SqlDataReader reader = DBSQL.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string claveDB = reader.GetString(0);
                        bool estado = reader.GetBoolean(1);

                        if (!estado)
                        {
                            ErrorUsuarioBloqueado();
                        }
                        else if (claveDB == clave)
                        {
                            OnLoginSuccessful?.Invoke();
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
            ConexionBD.Instancia.CerrarConexion();
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
        private void ErrorUsuarioBloqueado()
        {
            errorUsuarioDesactivado = new Frm_ErrorUsuarioDesactivado();
            errorUsuarioDesactivado.ShowDialog();
        }
        private void ErrorUsuarioDuplicado()
        {
            errorUsuarioDuplicado = new Frm_UsuarioDuplicado();
            errorUsuarioDuplicado.ShowDialog();
        }

        private void MostrarProcesoExitoso()
        {
            procesoExitosoForm = new Frm_ProcesoExitoso();
            procesoExitosoForm.ShowDialog();
        }

        private void MostrarProcesoFallido()
        {
            procesoFallidoForm = new Frm_ProcesoFallido();
            procesoFallidoForm.ShowDialog();
        }
    }
}
