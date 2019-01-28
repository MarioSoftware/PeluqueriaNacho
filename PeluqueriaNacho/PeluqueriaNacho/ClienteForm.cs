using System;
using System.Windows.Forms;
using Entities;
using Rules.Clientes;


namespace PeluqueriaNacho
{
    public partial class ClienteForm : Form
    {
        public Cliente clienteP { get; set; }
        public Contacto contactoP { get; set; }
        ClienteRepository clienteRepository = new ClienteRepository();
        public bool Nuevo { get; set; }
        public bool VerDetalle { get; set; }
        public bool Editar { get; set; }
        Cliente cliente = new Cliente();
        Contacto contacto = new Contacto();

        public ClienteForm()
        {
            InitializeComponent();
        }
           
        private void ClienteForm_Load(object sender, EventArgs e)
        {

           
            if (VerDetalle)
            {
               BindiarFormDetalle();
            }
            else if(Editar)
            {
                BindiarFormEditar();
            }
          
        }
        
        public void GuardarCliente()
        {
            
            cliente.Nombre = Convert.ToString( textBoxNombre.Text.ToUpper());
            cliente.Apellido = Convert.ToString(textBoxApellido.Text.ToUpper());
            if(string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                cliente.Nombre = "SIN NOMBRE";
            }
             if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                cliente.Apellido = "SIN APELLIDO";
            }
            cliente.FechaDeNacimiento = dateTimePickerFechaNacimiento.Value;
            cliente.Direccion = Convert.ToString(textBoxDireccion.Text.ToUpper());
            cliente.Localidad = Convert.ToString(textBoxLocalidad.Text.ToUpper());
            cliente.Observacion = Convert.ToString(textBoxObservacion.Text.ToUpper());
            cliente.Ocupacion = Convert.ToString(textBoxOcupacion.Text.ToUpper());
            if(!string.IsNullOrEmpty(Convert.ToString( textBoxEdad.Text)))
            {
                cliente.Edad = Convert.ToInt32(textBoxEdad.Text);
            }
         
            if (radioButtonFemenina.Checked)
            {
                cliente.Sexo = "F";
            }
            else if (radioButtonMasculino.Checked)
            {
                cliente.Sexo = "M";
            }

        
        }

        public void GuardarContacto()
        {
            
            contacto.Telefono = Convert.ToString(textBoxTelefono.Text);
            contacto.Celular = Convert.ToString(textBoxCelular.Text);
            contacto.CelularAlternativo = Convert.ToString(textBoxCelularAlternativo.Text);
            contacto.Email = Convert.ToString(textBoxEmail.Text);
            contacto.EmailAlternativo = Convert.ToString(textBoxEmailAlternativo.Text);
            contacto.Facebook = Convert.ToString(textBoxFacebook.Text.ToUpper());

        }

        public void BindiarFormDetalle()
        {
            textBoxNombre.Text = clienteP.Nombre;
            textBoxApellido.Text = clienteP.Apellido;
            dateTimePickerFechaNacimiento.Value = clienteP.FechaDeNacimiento;
            textBoxDireccion.Text = clienteP.Direccion;
            textBoxLocalidad.Text = clienteP.Localidad;
            textBoxOcupacion.Text = clienteP.Ocupacion;
            textBoxObservacion.Text = clienteP.Observacion;
            textBoxEdad.Text =Convert.ToString( clienteP.Edad);
            if(clienteP.Sexo=="M")
            {
                radioButtonMasculino.Checked = true;
            }
            else
            {
                radioButtonFemenina.Checked = true;
            }
            textBoxCelular.Text = contactoP.Celular;
            textBoxCelularAlternativo.Text = contactoP.CelularAlternativo;
            textBoxTelefono.Text = contactoP.Telefono;
            textBoxEmail.Text = contactoP.Email;
            textBoxEmailAlternativo.Text = contactoP.EmailAlternativo;
            textBoxFacebook.Text = contactoP.Facebook;

            //Apago elemenos del FORM
            textBoxNombre.Enabled=false;
            textBoxApellido.Enabled = false;
            dateTimePickerFechaNacimiento.Enabled = false;
            textBoxDireccion.Enabled = false;
            textBoxLocalidad.Enabled = false;
            textBoxOcupacion.Enabled = false;
            textBoxObservacion.Enabled = false;
            textBoxEdad.Enabled = false;
            radioButtonFemenina.Enabled = false;
            radioButtonMasculino.Enabled = false;


            textBoxCelular.Enabled = false;
            textBoxCelularAlternativo.Enabled = false;
            textBoxTelefono.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEmailAlternativo.Enabled = false;
            textBoxFacebook.Enabled = false;
            buttonAceptar.Enabled = false;




        }
        public void BindiarFormEditar()
        {
            textBoxNombre.Text = clienteP.Nombre;
            textBoxApellido.Text = clienteP.Apellido;
            dateTimePickerFechaNacimiento.Value = clienteP.FechaDeNacimiento;
            textBoxDireccion.Text = clienteP.Direccion;
            textBoxLocalidad.Text = clienteP.Localidad;
            textBoxOcupacion.Text = clienteP.Ocupacion;
            textBoxObservacion.Text = clienteP.Observacion;
            textBoxEdad.Text = Convert.ToString(clienteP.Edad);
            if (clienteP.Sexo == "M")
            {
                radioButtonMasculino.Checked = true;
            }
            else
            {
                radioButtonFemenina.Checked = true;
            }
            textBoxCelular.Text = contactoP.Celular;
            textBoxCelularAlternativo.Text = contactoP.CelularAlternativo;
            textBoxTelefono.Text = contactoP.Telefono;
            textBoxEmail.Text = contactoP.Email;
            textBoxEmailAlternativo.Text = contactoP.EmailAlternativo;
            textBoxFacebook.Text = contactoP.Facebook;

         
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(Nuevo)
            {
                if(radioButtonFemenina.Checked || radioButtonMasculino.Checked)
                {
                    GuardarCliente();
                    clienteRepository.InsertarCliente(cliente);
                    int IdCliente = clienteRepository.ReturnIdCliente();
                    contacto.IdCliente = IdCliente;
                    GuardarContacto();
                    try
                    {
                        clienteRepository.InsertarContacto(contacto);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL GUARDAR CLIENTE");
                    }

                }
                else
                {
                    MessageBox.Show("SELECCIONA EL SEXO !! ES OBLIGATORIO");
                }
            }
            else if(Editar)
            {
                GuardarCliente();
                cliente.Id = clienteP.Id;
                try
                {
                    clienteRepository.EditarCliente(cliente);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL EDITAR CLIENTE");
                }
                
                               
                GuardarContacto();
                contacto.IdCliente = clienteP.Id;
                try
                {
                    clienteRepository.EditarContacto(contacto);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL EDITAR CONTACTO DEL CLIENTE");
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxEdad.Text = Convert.ToString(clienteRepository.Edad(dateTimePickerFechaNacimiento.Value));
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CALCULAR LA EDAD ");
            }
           
        }
    }
}
