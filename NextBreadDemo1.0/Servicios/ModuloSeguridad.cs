using NextBreadDemo1._0.Conexion;
using NextBreadDemo1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBreadDemo1._0.Servicios
{
    public class ModuloSeguridad : IntUsuario
    {
        void IntUsuario.agregarUsuario(string nombre, string clave, int permiso, Boolean estado)
        {
            ConexionBD.Instancia.AbrirConexion();
            string queryDB = "INSERT INTO Usuarios (Nombre, Clave, Permiso, Estado) " +
                "VALUES (@Nombre, @Clave, @Permiso, @Estado)";
            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Clave", clave);
                DBSQL.Parameters.AddWithValue("@Permiso", permiso);
                DBSQL.Parameters.AddWithValue("@Estado", estado);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }
            ConexionBD.Instancia.CerrarConexion();
        }

        void IntUsuario.desactivarUsuario(string nombre, bool estado)
        {

            string queryDB = "UPDATE Usuarios SET Estado = @Estado WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

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
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Clave", clave);
                DBSQL.Parameters.AddWithValue("@Permiso", permiso);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }

        }

        bool IntUsuario.validarPermiso(string nombre)
        {
            int permiso = permisoActual(nombre);
            Boolean comportamiento = false;

            if (permiso == 1)
            {

                //Permisos tipo 1 lectura, los componentes de administracion y edicion deben estar
                //bloqueados.
                comportamiento = false;
            }
            if (permiso == 2)
            {

                //Permisos tipo 2 lectura y administracion, los componentes de administracion deben estar
                //activos, pero los de edicion no deben estarlo.
                comportamiento = true;
            }
            if (permiso == 3)
            {

                //Permisos tipo 3 lectura, administracion y edicion, los componenetes de administracion y
                // edicion deben estar activos.
                comportamiento = true;
            }
            return comportamiento;
        }

        private int permisoActual(string nombre)
        {
            ConexionBD.Instancia.AbrirConexion();
            string queryDB = "SELECT Permiso FROM Usuario WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB, ConexionBD.Instancia.GetConnection()))
            {//En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);

                using (SqlDataReader reader = DBSQL.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0); // Permiso
                    }
                    else
                    {
                        throw new Exception("Usuario no encontrado."); // Agregar un mensaje personalizado de alerta.
                    }
                }
            }

        }
    }
}
