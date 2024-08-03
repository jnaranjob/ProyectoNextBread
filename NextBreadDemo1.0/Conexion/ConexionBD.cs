using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace NextBreadDemo1._0.Conexion
{
    public class ConexionBD
    {
        private static readonly Lazy<ConexionBD> instancia =
        new Lazy<ConexionBD>(() => new ConexionBD());

        private SqlConnection conexion;

        private ConexionBD()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Panaderia"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }

        public static ConexionBD Instancia
        {
            get { return instancia.Value; }
        }

        public void AbrirConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return conexion;
        }
    }
}
