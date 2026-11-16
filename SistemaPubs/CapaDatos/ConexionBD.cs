using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaPubs.CapaDatos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion = "Server=localhost;Database=pubs;Uid=root;Pwd=;";

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public DataTable EjecutarConsulta(string query)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection con = AbrirConexion())
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        public void EjecutarComando(string query, MySqlParameter[] parametros = null)
        {
            using (MySqlConnection con = AbrirConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);
                cmd.ExecuteNonQuery();
            }
        }
    }
}