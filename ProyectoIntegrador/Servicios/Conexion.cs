
using Microsoft.Data.SqlClient;

namespace ProyectoIntegrador.Servicios
{
    public static class Conexion
    {
        private static readonly string cadenaConexion =
            "Server=localhost\\SQLEXPRESS;" +
            "Database=AlbergueGatitos;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
