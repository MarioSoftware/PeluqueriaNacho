using System;
using System.Data;
using System.Windows.Forms;
using Rules.Servicios;
using Entities;
using Rules.Clientes;

namespace PeluqueriaNacho
{
    public partial class Form1 : Form
    {
        ServiciosRepository servicioRepository = new ServiciosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        int segundos = 0;
        public ClienteLite clienteLocal { get; set; }

        public bool Acredito { get; set; }
        public Decimal RealTotal { get; set; }
        public decimal Debe { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        public void LimpiarServicio()
        {
            clienteLocal = null;
            textBoxProducto.Text = "";
            textBoxCliente.Text = "";
            textBoxDetalles.Text = "";
            labelTotal.Text = "00,00";
            textBoxTargeta.Text = "";
            buttonGuardar.Enabled = false;
            panel1.Visible = false;
            Debe = 0;
            Acredito = false;
            RealTotal = 0;
            labelMensageCredito.Visible = false;
            labelDebe.Visible = false;
            labelDebeValue.Visible = false;
        }
        

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.Nuevo = true;
            clienteForm.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ClienteGrilla clienteGrilla = new ClienteGrilla();
            clienteGrilla.ShowDialog();
        }

        private void verTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductoGrilla productoGrilla = new ProductoGrilla();
            productoGrilla.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            productoForm.Nuevo = true;
            productoForm.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarServicio();
        
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

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        

            CargarComboProductos();
             
            


        }

        public  Producto ObtenerProductoPorId()
        {
            var datatableProducto = servicioRepository.ConsultarProducto();
            int IdProducto =Convert.ToInt32( comboBoxProductos.SelectedValue);

            foreach (DataRow row in datatableProducto.Rows)
            {
                if(Convert.ToInt32( row["Id"])==IdProducto)
                {
                    
                    Producto producto = new Producto()
                    {
                        Id = Convert.ToInt32(comboBoxProductos.SelectedValue),
                        Precio = Convert.ToDecimal(row["Precio"]),
                        Descripcion=Convert.ToString(row["Descripcion"])
                        
                    };
                   
                    return producto;
                    
                }
            }
            return null;
          

        }

        public Producto ObtnereProductoPorDescripcion(string descripcion)
        {
            var datatableProducto = servicioRepository.ConsultarProducto();
            

            foreach (DataRow row in datatableProducto.Rows)
            {
                if (Convert.ToString(row["Descripcion"]) == descripcion)
                {
                    
                    Producto producto = new Producto()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Precio = Convert.ToDecimal(row["Precio"]),
                        Descripcion = Convert.ToString(row["Descripcion"])
                        
                    };
                   
                    return producto;
                }
            }
            return null;

        }

        private void comboBoxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            Producto productoInstancia = ObtenerProductoPorId();
           if(productoInstancia==null)
            {
                MessageBox.Show("ERROR AL RECUPERAR PRECIO Y NOMBRE DE ESTE PRODUCTO");
            } 
           else
            {
               
                textBoxProducto.Text = productoInstancia.Descripcion;
                labelTotal.Text =Convert.ToString( productoInstancia.Precio);
                if (Acredito)
                {
                    RealTotal = Convert.ToDecimal(productoInstancia.Precio);
                }
            }

            
        }

        private void buttonCorteMasculino_Click(object sender, EventArgs e)
        {
           
            Producto productoInstancia = ObtnereProductoPorDescripcion("CORTE MASCULINO");
            if( productoInstancia== null)
            {
                MessageBox.Show("NO SE ENCONTRO 'CORTE MASCULINO' EN LA LISTA DE PRODUCTOS,VERIFICA QUE EXISTA ESE ITEM Y REINTENTA NUEVAMENTE");
            }
            else
            {
                CargarComboProductos();
                comboBoxProductos.SelectedValue = productoInstancia.Id;
                labelTotal.Text =Convert.ToString( productoInstancia.Precio);
                textBoxProducto.Text = Convert.ToString(productoInstancia.Descripcion);
                if(Acredito)
                {
                    RealTotal = Convert.ToDecimal(productoInstancia.Precio);
                }
            }
        }

        private void buttonCorteFemenino_Click(object sender, EventArgs e)
        {
            Producto productoInstancia = ObtnereProductoPorDescripcion("CORTE FEMENINO");
            if (productoInstancia == null)
            {
                MessageBox.Show("NO SE ENCONTRO 'CORTE FEMENINO' EN LA LISTA DE PRODUCTOS,VERIFICA QUE EXISTA ESE ITEM Y REINTENTA NUEVAMENTE");
            }
            else
            {
                CargarComboProductos();
                comboBoxProductos.SelectedValue = productoInstancia.Id;
                labelTotal.Text = Convert.ToString(productoInstancia.Precio);
                textBoxProducto.Text = Convert.ToString(productoInstancia.Descripcion);
                if (Acredito)
                {
                    RealTotal = Convert.ToDecimal(productoInstancia.Precio);
                }
            }
        }

        private void buttonCorteNiño_Click(object sender, EventArgs e)
        {
            Producto productoInstancia = ObtnereProductoPorDescripcion("CORTE NIÑO");
            if (productoInstancia == null)
            {
                MessageBox.Show("NO SE ENCONTRO 'CORTE NIÑOS' EN LA LISTA DE PRODUCTOS,VERIFICA QUE EXISTA ESE ITEM Y REINTENTA NUEVAMENTE");
            }
            else
            {
                CargarComboProductos();
                comboBoxProductos.SelectedValue = productoInstancia.Id;
                labelTotal.Text = Convert.ToString(productoInstancia.Precio);
                textBoxProducto.Text = Convert.ToString(productoInstancia.Descripcion);
                if (Acredito)
                {
                    RealTotal = Convert.ToDecimal(productoInstancia.Precio);
                }
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

        private void buttonModificarTotal_Click(object sender, EventArgs e)
        {
            if(labelTotal.Text=="00,00")
            {
                MessageBox.Show("Para modificar el precio primero debes seleccionar un producto");
            }
       else
            {
                //Editar ACTIVADO
                if (textBoxTotal.Visible == false)
                {

                    buttonModificarTotal.Text = "Aceptar";
                    textBoxTotal.Visible = true;
                    textBoxTotal.Text = labelTotal.Text;
                  
                  
                }
                else
                {

                    buttonModificarTotal.Text = "Modificar";
                    try
                    {
                        decimal nuevoPrecio = Convert.ToDecimal(textBoxTotal.Text);
                        labelTotal.Text = textBoxTotal.Text;
                        textBoxTotal.Visible = false;
                        if (Acredito)
                        {
                          var abonado=  Convert.ToDecimal(labelTotal.Text);
                            Debe = RealTotal - abonado;
                            labelDebe.Visible = true;
                            labelDebeValue.Visible = true;
                            labelDebeValue.Text = Convert.ToString(Debe);
                        }
                      

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al modificar el precio, reintenta nuevamente con un precio valido.");
                    }
                  
                    

                }
            }
          
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCliente.Text)|| string.IsNullOrWhiteSpace(textBoxProducto.Text))
            {


            }
            else
            {
                buttonGuardar.Enabled = true;
            }
        }

        private void textBoxProducto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCliente.Text) || string.IsNullOrWhiteSpace(textBoxProducto.Text))
            {


            }
            else
            {
                buttonGuardar.Enabled = true;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //si no se guardo precio modificado no hacer nadaaaa!!
            Servicio servicio = new Servicio();
            servicio.IdCliente = clienteLocal.Id;
            servicio.IdProducto = Convert.ToInt32(comboBoxProductos.SelectedValue);
            servicio.FechaHora = DateTime.Now;
            servicio.Total = Convert.ToDecimal(labelTotal.Text);
            servicio.Detalles = Convert.ToString(textBoxDetalles.Text);

            if (radioButtonEfectivo.Checked)
            {
                //EFECTIVO
                servicio.FormaDePago = "EFECTIVO";
                servicio.NombreTarjeta = "";
                if(Acredito)
                {
                    servicio.Debe = Debe;
                    servicio.Acredito = "SI";
                   
                }
                else
                {
                    servicio.Debe = 0;
                    servicio.Acredito = "";
                }
                try
                {
                    servicioRepository.InsertarServicio(servicio);
                    LimpiarServicio();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ups,.NO SE PUDO GUARDAR ESTE TRABAJO, REINTENTA NUEVAMENTE Y SI EL ERROR PERSISTE COMUNICATE CON MARIO PEDERNERA 3544 - 659058");
                }

            }
            else
            {
                //TARGETA
                
                if(string.IsNullOrWhiteSpace(textBoxTargeta.Text))
                {
                    MessageBox.Show("INGRESA EL NOMBRE DE LA TARJETA !!");
                }
                else
                {
                    servicio.FormaDePago = "TARJETA";
                    servicio.NombreTarjeta = textBoxTargeta.Text.ToUpper();
                    if(Acredito)
                    {
                        servicio.Debe = Debe;
                        servicio.Acredito = "SI";
                    }
                    else
                    {
                        servicio.Debe = 0;
                        servicio.Acredito = "";
                    }
                }
                try
                {
                    servicioRepository.InsertarServicio(servicio);
                    LimpiarServicio();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ups,.NO SE PUDO GUARDAR ESTE TRABAJO, REINTENTA NUEVAMENTE Y SI EL ERROR PERSISTE COMUNICATE CON MARIO PEDERNERA 3544 - 659058");
                }
            }

       


         
           
        }

        private void verTodosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ServicioGrilla servicioGrilla = new ServicioGrilla();
            servicioGrilla.ShowDialog();
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

        private void buttonClienteRapido_Click(object sender, EventArgs e)
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

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCredito_Click(object sender, EventArgs e)
        {
            if(Acredito)
            {

            }
            else
            {
                if (labelTotal.Text == "00,00")
                {
                    MessageBox.Show("DEBES SELECCIONAR UN PRODUCTO");

                }
                else
                {
                    labelMensageCredito.Visible = true;
                    RealTotal = Convert.ToDecimal(labelTotal.Text);
                    Acredito = true;
                    buttonCancelarCredito.Visible = true;
                }
            }
        
        }

        private void radioButtonTargeta_CheckedChanged(object sender, EventArgs e)
        {
            labelNombreTargeta.Visible = true;
            textBoxTargeta.Visible = true;


        }

        private void radioButtonEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            labelNombreTargeta.Visible = false;
            textBoxTargeta.Visible = false;
           
        }

        private void buttonCancelarCredito_Click(object sender, EventArgs e)
        {
            labelTotal.Text = Convert.ToString(RealTotal);
            RealTotal = 0;
            labelMensageCredito.Visible = false;
            buttonCancelarCredito.Visible = false;
            Acredito = false;
            Debe = 0;
            labelDebeValue.Text = "00,00";
            labelDebeValue.Visible = false;
            labelDebe.Visible = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm();
            turnoForm.ShowDialog();

           
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TurnoGrilla turnoGrilla = new TurnoGrilla();
            turnoGrilla.ShowDialog();
        }

        public string Hora(string hora,string minuto)
        {
            return (hora + " : " + minuto);
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if(segundos==60)
            {
                segundos = 0;
                try
                {

                }
                catch (Exception)
                {

                    
                }

            }
                
        }
    }
}
