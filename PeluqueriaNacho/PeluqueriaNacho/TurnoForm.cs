using System;
using System.Data;
using System.Windows.Forms;
using Rules.Servicios;
using Entities;
using Rules.Clientes;
using Rules.Turnos;
namespace PeluqueriaNacho
{
    public partial class TurnoForm : Form
    {
        string hora = "";
        string minuto = "";
        decimal monto = 0;
        ServiciosRepository servicioRepository = new ServiciosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        TurnosRepository turnoRepository = new TurnosRepository();
        public ClienteLite clienteLocal { get; set; }
       

        public TurnoForm()
        {
            InitializeComponent();
        }

        public void CargarComboProductos()
        {
            try
            {
                comboBoxProductos.DataSource = servicioRepository.ConsultarProducto();
                comboBoxProductos.ValueMember = "Id";
                comboBoxProductos.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL TRAER LOS PRODUCTOS DE LA BASE DE DATOS");
            }
        }

        private void TurnoForm_Load(object sender, EventArgs e)
        {
            
            CargarComboProductos();
        }

        private void radioButtonNO_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMonto.Text = "";
            textBoxMonto.Visible = false;
            labelMonto.Visible = false;
        }

        private void radioButtonSI_CheckedChanged(object sender, EventArgs e)
        {
           
            textBoxMonto.Visible = true;
            textBoxMonto.Text = "";
            labelMonto.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxCliente.Text)|| string.IsNullOrWhiteSpace(textBoxProducto.Text))
            {

            }
            else
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCliente.Text) || string.IsNullOrWhiteSpace(textBoxProducto.Text))
            {

            }
            else
            {
                buttonAceptar.Enabled = true;
            }
        }

        public void InsertarClienteRapido(string sexo)
        {
            Cliente cliente = new Cliente
            {

                Nombre = "SIN NOMBRE",
                Apellido = "SIN APELLIDO",
                FechaDeNacimiento = DateTime.Now,
                Edad = 0,
                Sexo = sexo,
                Direccion = "",
                Localidad = "",
                Observacion = "",
                Ocupacion = ""
            };
            try
            {
                clienteRepository.InsertarCliente(cliente);
            }
            catch (Exception)
            {

            }

            ClienteLite clienteL = new ClienteLite();
            clienteL.Apellido = "SIN APELLIDO";
            clienteL.Nombre = "SIN NOMBRE";
            try
            {
                clienteL.Id = clienteRepository.ReturnIdCliente();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al recuperar el Id del ultimo cliente guardado !!");
            }

            Contacto contacto = new Contacto
            {
                Celular = "",
                CelularAlternativo = "",
                Email = "",
                EmailAlternativo = "",
                Facebook = "",
                Telefono = "",
                IdCliente = clienteL.Id
            };
            try
            {
                clienteRepository.InsertarContacto(contacto);
            }
            catch (Exception)
            {
                MessageBox.Show("Huvo un error al intentar guardar info de Contacto para el cliente rapido !!");
            }


            clienteLocal = clienteL;

            clienteLocal.Nombre = "SIN NOMBRE";
            clienteLocal.Apellido = "SIN APELLIDO";
            clienteLocal.Id = clienteL.Id;

            textBoxCliente.Text = cliente.Nombre + " " + cliente.Apellido;
        }

        private void buttonMaculinoRapido_Click(object sender, EventArgs e)
        {

            try
            {
                InsertarClienteRapido("M");
             
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR al guardar el cliente Rapido");
            }


        }

        private void buttonFemeninoRapido_Click(object sender, EventArgs e)
        {
            try
            {
                InsertarClienteRapido("F");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR al guardar cliente rapido");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ClienteBuscar clienteBuscar = new ClienteBuscar();
            clienteBuscar.ShowDialog();
            ClienteLite cliente = new ClienteLite();
            try
            {
                cliente.Id = clienteBuscar.clienteLite.Id;
                cliente.Nombre = clienteBuscar.clienteLite.Nombre;
                cliente.Apellido = clienteBuscar.clienteLite.Apellido;

                clienteLocal = cliente;


                textBoxCliente.Text = cliente.Nombre + " " + cliente.Apellido;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL TRATAR DE SELECCIONAR CLIENTE, REINTENTA NUEVAMENTE");
            }
           
        }
               
        private void comboBoxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                textBoxProducto.Text = ObtenerProductoPorId(Convert.ToInt32( comboBoxProductos.SelectedValue));
            }
            catch (Exception)
            {

                MessageBox.Show("Acontesio un error al intentar obtener el Producto");

            }
                
              
            
        }

        public DateTime ObtenerFechaConHoraTurno(DateTime fecha,string hora, string minuto)
        {
            string fechaString =  fecha.ToString("dd/MM/yyyy ");
                

            string fechaTurno = fechaString +hora+":"+minuto+":00";

            DateTime f = Convert.ToDateTime(fechaTurno);
            


            return f;
        }

        public string ObtenerProductoPorId(int IdProducto)
        {
            var datatableProducto = servicioRepository.ConsultarProducto();
            

            foreach (DataRow row in datatableProducto.Rows)
            {
                if (Convert.ToInt32(row["Id"]) == IdProducto)
                {



                    var descripcion = Convert.ToString(row["Descripcion"]);

                    

                    return descripcion ;

                }
            }
            return null;


        }

        public bool ObtenerEstadoTurno(DateTime Turno)
        {
            var hoy = DateTime.Now;

            if(Turno>hoy)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public void CapturarValoresTurno(string hora,string minuto,decimal monto,bool senia)
        {

            Turno turno = new Turno();

            if (textBoxProducto.Text == "INDEFINIDO")
            {
                turno.Producto = "INDEFINIDO";
                // IdProducto setiar como -1


            }
            else
            {
                //IdProducto del comboBox
                
                    turno.Producto =textBoxProducto.Text;
                  
                
            } 
            turno.HoraProgramada = hora + " : " + minuto;
            //turno.FechaProgramada = Convert.ToDateTime(ObtenerFechaSinHora(dateTimePicker1.Value)) ;
            turno.FechaProgramada = dateTimePicker1.Value;
            turno.IdCliente = clienteLocal.Id;
            turno.Estado = "VIGENTE";
            


            //Obtengo Fecha y Hora del turno para chekear si estara vigente
          
                turno.Estado = "VIGENTE";
                if (senia)
                {
                    turno.Senia = "SI";
                    turno.Monto = monto;
                }
                else
                {
                    turno.Senia = "NO";

                }

                try
                {

                    turnoRepository.InsertarTurno(turno);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL GUARDAR EL TURNO ");
                }
            
            

         



}

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            
            
                hora = Convert.ToString(comboBoxHora.SelectedItem);
                minuto = Convert.ToString(comboBoxMinutos.SelectedItem);
                if (string.IsNullOrWhiteSpace(hora) || string.IsNullOrWhiteSpace(minuto))
                {
                    //NO SE SETIO HORA 
                    MessageBox.Show("Selecciona la HORA y MINUTO para el turno !");
                    return;
                }
                else
                {
                var fechaTurno = ObtenerFechaConHoraTurno(dateTimePicker1.Value, hora, minuto);
                var hoy = DateTime.Now;
              if(hoy <= fechaTurno)
                {
                    //TURNO Vigente
                    //SI SE SETIO HORA
                    if (radioButtonSI.Checked)
                    {
                        //Si hay seña
                        if (string.IsNullOrWhiteSpace(textBoxMonto.Text))
                        {
                            MessageBox.Show("Debes ingresar un Monto para la Seña");
                            return;
                        }
                        else
                        {

                            try
                            {
                                monto = Convert.ToDecimal(textBoxMonto.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ingresa un Monto valido !");
                                return;
                            }
                            // TOMAR VALORES PARA TURNO
                            CapturarValoresTurno(hora, minuto, monto, true);

                        }

                    }
                    else
                    {
                        //No hay seña
                        // TOMAR VALORES PARA TURNO
                        CapturarValoresTurno(hora, minuto, monto, false);


                    }

                }
                else
                {
                    //TURNO Vencido
                    MessageBox.Show("Selecciona una Fecha y Hora futura para agendar un turno, la fecha ingresada ya ha pasado !");
                    return;
                }

                }

           

          
        }

        private void buttonIndefinido_Click(object sender, EventArgs e)
        {
            textBoxProducto.Text = ("INDEFINIDO");
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
