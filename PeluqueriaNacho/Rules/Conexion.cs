using System.Data.SqlClient;

namespace Rules
{
    public class Conexion
    {

        public SqlConnection conexion { get; set; }
        public string ruta { get; set; }

        public void Abir()
        {

           ruta = @"Server=USUARIOPC-PC\SQLEXPRESS;Database=PeluqueriaDb;Trusted_Connection=True;";

            conexion = new SqlConnection(ruta);

            conexion.Open();

        }

        public void Cerrar()
        {
            
            conexion.Close();
        }


    }
}
