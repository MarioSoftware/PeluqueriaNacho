using Entities;
using System.Data;
using System.Data.SqlClient;


namespace Rules.Servicios
{
   public class ServiciosRepository
    {
        Conexion conexion = new Conexion();

        //Producto
        public void InsertarProducto(Producto producto)
        {
            conexion.Abir();
            SqlCommand comando = new SqlCommand("InsertarProducto", conexion.conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("Precio", producto.Precio);

            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }

        public void EditarProducto(Producto producto)
        {

            conexion.Abir();
            SqlCommand comando = new SqlCommand("EditarProducto", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Id", producto.Id);
            comando.Parameters.AddWithValue("Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("Precio", producto.Precio);
            

            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }

        public DataTable ConsultarProducto()
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("ConsultarProducto", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();


            dataAdapter.Fill(dataTable);
            
            return dataTable;

        }

        public void EliminarProducto (int IdProducto)
        {
             conexion.Abir();
            SqlCommand comando = new SqlCommand("EliminarProducto", conexion.conexion);

        comando.CommandType =  CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("IdProducto", IdProducto);
            
            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }



    //SERVICIO

    public void InsertarServicio(Servicio servicio)
        {

            conexion.Abir();
            SqlCommand comando = new SqlCommand("InsertarServicio", conexion.conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("IdCliente", servicio.IdCliente);
            comando.Parameters.AddWithValue("IdProducto", servicio.IdProducto);
            comando.Parameters.AddWithValue("Total", servicio.Total);
            comando.Parameters.AddWithValue("Detalles", servicio.Detalles);
            comando.Parameters.AddWithValue("FechaHora", servicio.FechaHora);
            comando.Parameters.AddWithValue("Acredito", servicio.Acredito);
            comando.Parameters.AddWithValue("Debe", servicio.Debe);
            comando.Parameters.AddWithValue("FormaDePago", servicio.FormaDePago);
            comando.Parameters.AddWithValue("NombreTarjeta", servicio.NombreTarjeta);

            comando.ExecuteNonQuery();
            conexion.Cerrar();


        }

        public DataTable ConsultarServicioFiltro(int IdCliente)
        {
            conexion.Abir();

            string consulta = " select s.Id,c.Nombre Cliente, s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.NombreTarjeta,s.Acredito,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto  where IdCliente like " + IdCliente;

            
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ConsultarServicioFiltroProducto(int IdProducto)
        {
            conexion.Abir();

            string consulta = " select s.Id,c.Nombre Cliente, s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.Acredito,s.NombreTarjeta,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto  where IdProducto like " + IdProducto;


            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ConsultarServicioFiltroFormaPago( string FormaDepago)
        {
            conexion.Abir();

            string consulta = " select  s.Id,c.Nombre Cliente, s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.NombreTarjeta,s.Acredito,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto  where FormaDePago = '" + FormaDepago+"'";


            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ConsultarServicioFiltroAcredito()
        {
            conexion.Abir();

            string consulta = " select s.Id, c.Nombre Cliente, s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.NombreTarjeta,s.Acredito,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto  where Credito='SI'";


            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ConsultarServicioFiltroDeuda()
        {
            conexion.Abir();

            string consulta = " select s.Id, c.Nombre Cliente, s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.NombreTarjeta,s.Acredito,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto  where Debe > 0";


            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable ConsultarServicio()
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("ConsultarServicio", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            
            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        public DataTable ConsultarServicioFiltroFecha(string inicio,string fin)
        {
            conexion.Abir();
            string consulta = " select s.Id, c.Nombre Cliente,s.FechaHora, p.Descripcion Producto, s.Total,s.FormaDePago,s.Acredito,s.NombreTarjeta,s.Debe,s.detalles from servicio s inner join cliente c on c.id = s.IdCliente inner join producto p on p.id = s.idproducto where fechahora between '" + inicio+"' and '"+fin+"'";
            

          

            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            return dataTable;

        }

        public void AbonarDeuda(int Id, decimal debe,decimal total)
        {

            conexion.Abir();
            SqlCommand comando = new SqlCommand("EditarDeuda", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Id", Id);
            comando.Parameters.AddWithValue("Debe", debe);
            comando.Parameters.AddWithValue("Total", total);


            comando.ExecuteNonQuery();
            conexion.Cerrar();
        }

    }
}
