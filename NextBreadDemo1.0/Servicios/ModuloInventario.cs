using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Forms.Avisos.Generales;
using NextBreadDemo1._0.Forms.Avisos;
using NextBreadDemo1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Forms.Avisos.Inventario;

namespace NextBreadDemo1._0.Servicios
{
    public class ModuloInventario : IntInventario
    {

        private IntUsuario moduloSeguridad;
        private static Frm_ProcesoExitoso procesoExitosoForm;
        private static Frm_ProcesoFallido procesoFallidoForm;
        private static Frm_ExcepcionCampoNull procesoFallidoInventario;
        private static Frm_ExcepcionDuplicados procesoDuplicadoInventario;
        private static Frm_Inventario inventario;

        public ModuloInventario()
        {

            moduloSeguridad = new ModuloSeguridad();

        }

        public void agregarProducto(long codigoP, string nombre, int precioCosto, int cantidad, string nombreProveedor, bool estado, string nombreUsuario)
        {
            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {
                try
                {
                    ConexionBD.Instancia.AbrirConexion();

                    string queryCheck = "SELECT COUNT(*) FROM Inventario WHERE CodigoProducto = @CodigoProducto";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, ConexionBD.Instancia.GetConnection()))
                    {
                        cmdCheck.Parameters.AddWithValue("@CodigoProducto", codigoP);
                        long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

                        if (count > 0)
                        {
                            MostrarProcesoDuplicadoInventario();
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

                    int idProveedor = 0;
                    string queryProveedor = "SELECT IdProveedor FROM Proveedor WHERE Nombre = @NombreProveedor";
                    using (SqlCommand cmdProveedor = new SqlCommand(queryProveedor, ConexionBD.Instancia.GetConnection()))
                    {
                        cmdProveedor.Parameters.AddWithValue("@NombreProveedor", nombreProveedor);
                        object result = cmdProveedor.ExecuteScalar();
                        if (result != null)
                        {
                            idProveedor = Convert.ToInt32(result);
                        }
                        else
                        {
                            MostrarProcesoFallidoInventario();
                            return;
                        }
                    }

                    string queryDB = "INSERT INTO Inventario (CodigoProducto, Nombre, Precio, Cantidad, IdProveedor, Estado, IdUsuario) VALUES (@CodigoProducto, @Nombre, @Precio, @Cantidad, @IdProveedor, @Estado, @IdUsuario)";
                    using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
                    { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                        DBSQL.Parameters.AddWithValue("@CodigoProducto", codigoP);
                        DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                        DBSQL.Parameters.AddWithValue("@Estado", estado);
                        DBSQL.Parameters.AddWithValue("@Precio", precioCosto);
                        DBSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                        DBSQL.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        DBSQL.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        DBSQL.ExecuteNonQuery();

                        MostrarProcesoExitoso();
                    }
                }
                catch (Exception ex)
                {
                    MostrarProcesoFallido();
                    MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
                }
                finally
                {
                    ConexionBD.Instancia.CerrarConexion();
                }
            }

        }
        public void editarProducto(long codigoP, string nombre, int precioCosto,  int cantidad, string nombreProveedor, bool estado, string nombreUsuario)
        {

            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
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
                            MostrarProcesoDuplicadoInventario();
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

                    int idProveedor = 0;
                    string queryProveedor = "SELECT IdProveedor FROM Proveedor WHERE Nombre = @NombreProveedor";
                    using (SqlCommand cmdProveedor = new SqlCommand(queryProveedor, ConexionBD.Instancia.GetConnection()))
                    {
                        cmdProveedor.Parameters.AddWithValue("@NombreProveedor", nombreProveedor);
                        object result = cmdProveedor.ExecuteScalar();
                        if (result != null)
                        {
                            idProveedor = Convert.ToInt32(result);
                        }
                        else
                        {
                            MostrarProcesoFallidoInventario();
                            return;
                        }
                    }

                    string queryDB = "UPDATE Inventario SET CodigoProducto = @CodigoProducto, Nombre = @Nombre, Precio = @Precio, Cantidad = @Cantidad, IdProveedor = @IdProveedor, Estado = @Estado, IdUsuario = @IdUsuario WHERE CodigoProducto = @CodigoProducto";
                    using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
                    {

                        DBSQL.Parameters.AddWithValue("@CodigoProducto", codigoP);
                        DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                        DBSQL.Parameters.AddWithValue("@Precio", precioCosto);
                        DBSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                        DBSQL.Parameters.AddWithValue("@IdProveedor", idProveedor);
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

        private void MostrarProcesoFallidoInventario()
        {
            procesoFallidoInventario = new Frm_ExcepcionCampoNull();
            procesoFallidoInventario.ShowDialog();
        }

        private void MostrarProcesoDuplicadoInventario()
        {
            procesoDuplicadoInventario = new Frm_ExcepcionDuplicados();
            procesoDuplicadoInventario.ShowDialog();
        }

    }
}
