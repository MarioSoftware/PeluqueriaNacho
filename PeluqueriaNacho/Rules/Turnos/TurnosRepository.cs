using Entities;
using System.Data;
using System.Data.SqlClient;


namespace Rules.Turnos
{
   public class TurnosRepository
    {
        Conexion conexion = new Conexion();

        
        public void InsertarTurno(Turno turno)
        {
            conexion.Abir();
            SqlCommand comando = new SqlCommand("InsertarTurno", conexion.conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("FechaProgramada", turno.FechaProgramada);
            comando.Parameters.AddWithValue("HoraProgramada", turno.HoraProgramada);
			comando.Parameters.AddWithValue("IdCliente", turno.IdCliente);
			comando.Parameters.AddWithValue("Producto", turno.Producto);
			comando.Parameters.AddWithValue("Senia", turno.Senia);
			comando.Parameters.AddWithValue("Monto", turno.Monto);
			 

			comando.ExecuteNonQuery();
            conexion.Cerrar();
        }

        public DataTable ConsultarTurnoFiltroFecha(string inicio, string fin)
        {
            conexion.Abir();
            string consulta = " SELECT t.Id,t.FechaProgramada,t.HoraProgramada,c.Nombre Cliente, t.Producto,t.Senia,t.Monto,t.Estado FROM Turno t inner join Cliente c on c.Id = t.IdCliente  where FechaProgramada between '" + inicio + "' and '" + fin + "'";




            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        public DataTable ConsultarTurnoFiltroEstado(string estado)
        {
            conexion.Abir();
            string consulta = " SELECT t.Id,t.FechaProgramada,t.HoraProgramada,c.Nombre Cliente, t.Producto,t.Senia,t.Monto,t.Estado FROM Turno t inner join Cliente c on c.Id = t.IdCliente  where Estado like '" + estado +"'";




            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        public DataTable ConsultarTurnos()
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("ConsultarTurnos", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);

            return dataTable;

        }




    }
}
