using System;
using Entities;
using System.Data;
using System.Data.SqlClient;




namespace Rules.Clientes
{
   public class ClienteRepository
    {
        
        Conexion conexion = new Conexion();



        public void InsertarCliente (Cliente cliente)
        {
            conexion.Abir();
            SqlCommand comando = new SqlCommand("InsertarCliente", conexion.conexion);

            comando.CommandType =  CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("FechaDeNacimiento", cliente.FechaDeNacimiento);
            comando.Parameters.AddWithValue("Sexo", cliente.Sexo);
            comando.Parameters.AddWithValue("Edad", cliente.Edad);
            comando.Parameters.AddWithValue("Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("Localidad", cliente.Localidad);
            comando.Parameters.AddWithValue("Ocupacion", cliente.Ocupacion);
            comando.Parameters.AddWithValue("Observacion", cliente.Observacion);

            comando.ExecuteNonQuery();
            conexion.Cerrar();

        }

        public int ReturnIdCliente ()
        {
            conexion.Abir();
            SqlCommand comando = new SqlCommand("ReturnIdCliente", conexion.conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            var a = comando.ExecuteScalar().ToString();

           int b = Convert.ToInt32(a);
            
            conexion.Cerrar();

            return b;
        }
        
        public void InsertarContacto(Contacto contacto)
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("InsertarContacto", conexion.conexion);

            comando.CommandType =  CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("IdCliente", contacto.IdCliente);
            comando.Parameters.AddWithValue("Telefono", contacto.Telefono);
            comando.Parameters.AddWithValue("Celular", contacto.Celular);
            comando.Parameters.AddWithValue("CelularAlternativo", contacto.CelularAlternativo);
            comando.Parameters.AddWithValue("Email", contacto.Email);
            comando.Parameters.AddWithValue("EmailAlternativo", contacto.EmailAlternativo);
            comando.Parameters.AddWithValue("Facebook", contacto.Facebook);
            comando.ExecuteNonQuery();
            conexion.Cerrar();

        }
        
        public DataTable ConsultarClientes()
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("ConsultarClientes", conexion.conexion);
            comando.CommandType =  CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();


            dataAdapter.Fill(dataTable);
            return dataTable;

        }

        public DataTable ConsultarContacto(int IdCliente)
        {
            conexion.Abir();

            string consulta = "select * from Contacto where IdCliente like " + IdCliente;
            
            SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                      
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
          
            return dataTable;


        }

        public DataTable ConsultarPorFiltro(string tipo, string textSearch )
        {
            string consulta;
            DataTable dataTable = new DataTable();

          
           if(tipo=="Sexo")
            {
                consulta = "select * from Cliente where Sexo like '" + textSearch+"%'";
                conexion.Abir();
                SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);

            }
           else if(tipo=="Nombre")
            {
                consulta = "select * from Cliente where Nombre like '" + textSearch + "%'";
                conexion.Abir();
                SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);

            }
           else if(tipo=="Apellido")
            {
                consulta = "select * from Cliente where Apellido like '" + textSearch + "%'";
                conexion.Abir();
                SqlCommand comando = new SqlCommand(consulta, conexion.conexion);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
            }

            return dataTable;


        }

        public void EditarCliente (Cliente cliente)
        {
            conexion.Abir();
            SqlCommand comando = new SqlCommand("EditarCliente", conexion.conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Id", cliente.Id);
            comando.Parameters.AddWithValue("Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("FechaDeNacimiento", cliente.FechaDeNacimiento);
            comando.Parameters.AddWithValue("Sexo", cliente.Sexo);
            comando.Parameters.AddWithValue("Edad", cliente.Edad);
            comando.Parameters.AddWithValue("Direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("Localidad", cliente.Localidad);
            comando.Parameters.AddWithValue("Ocupacion", cliente.Ocupacion);
            comando.Parameters.AddWithValue("Observacion", cliente.Observacion);

            comando.ExecuteNonQuery();
            conexion.Cerrar();


        }

        public void EditarContacto (Contacto contacto)
        {
            conexion.Abir();

            SqlCommand comando = new SqlCommand("EditarContacto", conexion.conexion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("IdCliente", contacto.IdCliente);
            comando.Parameters.AddWithValue("Telefono", contacto.Telefono);
            comando.Parameters.AddWithValue("Celular", contacto.Celular);
            comando.Parameters.AddWithValue("CelularAlternativo", contacto.CelularAlternativo);
            comando.Parameters.AddWithValue("Email", contacto.Email);
            comando.Parameters.AddWithValue("EmailAlternativo", contacto.EmailAlternativo);
            comando.Parameters.AddWithValue("Facebook", contacto.Facebook);
            comando.ExecuteNonQuery();
            conexion.Cerrar();

        }

        public int Edad(DateTime fechaDeNacimiento)
        {
           var now = DateTime.Now;
            int age = now.Year - fechaDeNacimiento.Year;
            if (now.Month < fechaDeNacimiento.Month || (now.Month == fechaDeNacimiento.Month &&
                now.Day < fechaDeNacimiento.Day))
                age--;
            return age; 

        }

       
    }
}
