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
        private static Frm_ErrorUsuarioSeguridad errorCodigoUsuario;

        public delegate void LoginSuccessfulHandler();
        public event LoginSuccessfulHandler OnLoginSuccessful;
        private int intentosFallidos = 0;
        private const int maxIntentos = 5;

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
        void IntUsuario.editarUsuario(int idUsuario, string nombre, string clave, int permiso, bool estado)
        {
            try
            {
                ConexionBD conexionBD = ConexionBD.Instancia;
                conexionBD.AbrirConexion();

                using (SqlConnection connection = conexionBD.CrearNuevaConexion())
                {
                    connection.Open();

                    string queryDB = "UPDATE Usuario SET Nombre = @Nombre, Clave = @Clave, Permiso = @Permiso, Estado = @Estado WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand DBSQL = new SqlCommand(queryDB, connection))
                    {
                        DBSQL.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                        DBSQL.Parameters.AddWithValue("@Clave", clave);
                        DBSQL.Parameters.AddWithValue("@Permiso", permiso);
                        DBSQL.Parameters.AddWithValue("@Estado", estado);

                        int rowsAffected = DBSQL.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MostrarProcesoExitoso();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un usuario con ese ID.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MostrarProcesoFallido();
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }

        int IntUsuario.validarPermiso(string nombre)
        {
            int permiso = permisoActual(nombre);

            return permiso;
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
            try
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
                                intentosFallidos = 0;
                                OnLoginSuccessful?.Invoke();
                            }
                            else
                            {
                                intentosFallidos++;

                                if (intentosFallidos >= maxIntentos)
                                {
                                    DesactivarUsuario(nombre);
                                    ErrorUsuarioDesactivado();
                                }
                                else
                                {
                                    ErrorLoginClave();
                                }
                            }
                        }
                        else
                        {
                            ErrorLoginUsuarioForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación de credenciales: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }
        private void DesactivarUsuario(string nombre)
        {
            using (SqlConnection nuevaConexion = ConexionBD.Instancia.CrearNuevaConexion())
            {
                try
                {
                    nuevaConexion.Open();

                    string updateQuery = "UPDATE Usuario SET Estado = 0 WHERE Nombre COLLATE Latin1_General_BIN = @Nombre";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, nuevaConexion))
                    {
                        updateCmd.Parameters.AddWithValue("@Nombre", nombre);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desactivar el usuario: " + ex.Message);
                }
                finally
                {
                    nuevaConexion.Close();
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
        private void ErrorUsuarioDesactivado()
        {
            errorCodigoUsuario = new Frm_ErrorUsuarioSeguridad();
            errorCodigoUsuario.ShowDialog();
        }
    }
}
