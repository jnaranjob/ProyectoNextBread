using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos.Inventario;
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
    public class ModuloProveedor : IntProveedor
    {

        private IntUsuario moduloSeguridad;
        private static Frm_ProcesoExitoso procesoExitosoForm;
        private static Frm_ProcesoFallido procesoFallidoForm;
        private static Frm_ExcepcionDuplicados procesoDuplicadoProveedores;

        public ModuloProveedor()
        {
            moduloSeguridad = new ModuloSeguridad();
        }
        public void agregarProveedor(string nombre, bool estado, string nombreUsuario)
        {

            int tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);
            try
            {

                ConexionBD.Instancia.AbrirConexion();

                string nombreNormalizado = nombre.ToLower().Replace(" ", "");

                string queryCheck = "SELECT COUNT(*) FROM Proveedor WHERE REPLACE(LOWER(Nombre), ' ', '') = @NombreNormalizado";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, ConexionBD.Instancia.GetConnection()))
                {
                    cmdCheck.Parameters.AddWithValue("@NombreNormalizado", nombreNormalizado);
                    long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        MostrarProcesoDuplicadoProveedores();
                        return;
                    }
                }

                int idUsuario = 0;
                string user = nombreUsuario;

                string queryUsuario = "SELECT IdUsuario FROM Usuario WHERE Nombre = @user";
                using (SqlCommand cmdProveedor = new SqlCommand(queryUsuario, ConexionBD.Instancia.GetConnection()))
                {
                    cmdProveedor.Parameters.AddWithValue("@user", user);
                    object result = cmdProveedor.ExecuteScalar();
                    if (result != null)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string queryDB = "INSERT INTO Proveedor (Nombre, Estado, IdUsuario) VALUES (@Nombre, @Estado, @IdUsuario)";
                using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
                {

                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                    DBSQL.Parameters.AddWithValue("@Estado", estado);
                    DBSQL.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    DBSQL.ExecuteNonQuery();

                    MostrarProcesoExitoso();
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

        public void editarProveedor(int codigo, string nombre, bool estado, string nombreUsuario)
        {
            try
            {

                ConexionBD.Instancia.AbrirConexion();

                string nombreNormalizado = nombre.ToLower().Replace(" ", "");

                string queryCheck = "SELECT COUNT(*) FROM Proveedor WHERE REPLACE(LOWER(Nombre), ' ', '') = @NombreNormalizado";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, ConexionBD.Instancia.GetConnection()))
                {
                    cmdCheck.Parameters.AddWithValue("@NombreNormalizado", nombreNormalizado);
                    long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        MostrarProcesoDuplicadoProveedores();
                        return;
                    }
                }

                int idUsuario = 0;
                string user = nombreUsuario;

                string queryUsuario = "SELECT IdUsuario FROM Usuario WHERE Nombre = @user";
                using (SqlCommand cmdProveedor = new SqlCommand(queryUsuario, ConexionBD.Instancia.GetConnection()))
                {
                    cmdProveedor.Parameters.AddWithValue("@user", user);
                    object result = cmdProveedor.ExecuteScalar();
                    if (result != null)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string queryDB = "UPDATE Proveedor SET Nombre = @Nombre, Estado = @Estado, IdUsuario = @IdUsuario WHERE IdProveedor = @IdProveedor";

                using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
                {

                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                    DBSQL.Parameters.AddWithValue("@Estado", estado);
                    DBSQL.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    DBSQL.Parameters.AddWithValue("@IdProveedor", codigo);

                    DBSQL.ExecuteNonQuery();

                    MostrarProcesoExitoso();
                }


            }
            catch (Exception ex)
            {

                MostrarProcesoFallido();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
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

        private void MostrarProcesoDuplicadoProveedores()
        {
            procesoDuplicadoProveedores = new Frm_ExcepcionDuplicados();
            procesoDuplicadoProveedores.ShowDialog();
        }

    }
}
