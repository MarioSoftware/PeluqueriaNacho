using System;
using System.Windows.Forms;
using Rules.Clientes;
using Entities;


namespace PeluqueriaNacho
{
    public partial class ClienteGrilla : Form
    {


        ClienteRepository clienteRepository = new ClienteRepository();

    

        public ClienteGrilla()
        {
            InitializeComponent();
        }

        private void ClienteGrilla_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarClientes();
                dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL TRAER CLIENTES DESDE LA BASE DE DATOS");
            }
             

        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //TOMO VALORES DE LA FILA SELECCIONADA Y CONSULTO CONTACTO RESPECTIVO
            if (dataGridView1.Rows[e.RowIndex].Cells["Id"].Value==null)
            {
                


            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                cliente.Nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                cliente.Apellido = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                cliente.Sexo = dataGridView1.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();
                cliente.FechaDeNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FechaDeNacimiento"].Value);
                cliente.Edad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Edad"].Value);
                cliente.Direccion = dataGridView1.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                cliente.Localidad = dataGridView1.Rows[e.RowIndex].Cells["Localidad"].Value.ToString();
                cliente.Ocupacion = dataGridView1.Rows[e.RowIndex].Cells["Ocupacion"].Value.ToString();
                cliente.Observacion = dataGridView1.Rows[e.RowIndex].Cells["Observacion"].Value.ToString();
                

                //TRAIGO CONTACTO
                var contactoDataTable = clienteRepository.ConsultarContacto(cliente.Id);

                Contacto contacto = new Contacto();
                try
                { contacto.IdCliente = cliente.Id; }
                catch (Exception)
                { }
                try
                { contacto.Celular = contactoDataTable.Rows[0]["Celular"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.CelularAlternativo = contactoDataTable.Rows[0]["CelularAlternativo"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.Telefono = contactoDataTable.Rows[0]["Telefono"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.Email = contactoDataTable.Rows[0]["Email"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.EmailAlternativo = contactoDataTable.Rows[0]["EmailAlternativo"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.Facebook = contactoDataTable.Rows[0]["Facebook"].ToString(); }
                catch (Exception)
                { }

                ////MANDO LA ENTIDAD CLIENTE Y CONTACTO AL FORM CLIENTE
                ClienteForm clienteForm = new ClienteForm();
                clienteForm.clienteP = cliente;
                clienteForm.contactoP = contacto;
                clienteForm.VerDetalle = true;
                clienteForm.ShowDialog();
            }

          }

        private void buttonAgregarNuevo_Click(object sender, EventArgs e)
        {
        
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.Nuevo = true;
            clienteForm.ShowDialog();
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarClientes();
            }
            catch (Exception)
            {

                MessageBox.Show("Error AL TRAER LOS CLIENTES DE LA BASE DE DATOS");
            }
           
        }

        private void buttonEditar_Click(object sender, EventArgs e )
        {
            

            //TOMO VALORES DE LA FILA SELECCIONADA Y CONSULTO CONTACTO RESPECTIVO
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value)==0)
            {

            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                cliente.Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                cliente.Apellido = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                cliente.Sexo = dataGridView1.SelectedRows[0].Cells["Sexo"].Value.ToString();
                cliente.FechaDeNacimiento = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaDeNacimiento"].Value.ToString());
                cliente.Edad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Edad"].Value.ToString());
                cliente.Direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString(); 
                cliente.Localidad = dataGridView1.SelectedRows[0].Cells["Localidad"].Value.ToString(); 
                cliente.Ocupacion = dataGridView1.SelectedRows[0].Cells["Ocupacion"].Value.ToString(); 
                cliente.Observacion = dataGridView1.SelectedRows[0].Cells["Observacion"].Value.ToString(); 
               

                //TRAIGO CONTACTO
                var contactoDataTable = clienteRepository.ConsultarContacto(cliente.Id);

                Contacto contacto = new Contacto();
                try
                { contacto.IdCliente = cliente.Id; }
                catch (Exception)
                { }
                try
                { contacto.Celular = contactoDataTable.Rows[0]["Celular"].ToString(); }
                catch (Exception)
                { }
                try
                {contacto.CelularAlternativo = contactoDataTable.Rows[0]["CelularAlternativo"].ToString();}
                catch (Exception)
                { }
                try
                { contacto.Telefono = contactoDataTable.Rows[0]["Telefono"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.Email = contactoDataTable.Rows[0]["Email"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.EmailAlternativo = contactoDataTable.Rows[0]["EmailAlternativo"].ToString(); }
                catch (Exception)
                { }
                try
                { contacto.Facebook = contactoDataTable.Rows[0]["Facebook"].ToString(); }
                catch (Exception)
                { }


                ////MANDO LA ENTIDAD CLIENTE Y CONTACTO AL FORM CLIENTE
                ClienteForm clienteForm = new ClienteForm();
                clienteForm.clienteP = cliente;
                clienteForm.contactoP = contacto;
                clienteForm.Editar = true;
                clienteForm.ShowDialog();
                try
                {
                    dataGridView1.DataSource = clienteRepository.ConsultarClientes();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER LOS CLIENTES DE LA BASE DE DATOS");
                }
            }
          
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem =="Sexo")
            {
                panelSearch.Visible = true;
                radioButtonFemenino.Visible = true;
                radioButtonMasculino.Visible = true;
                textBoxApellido.Visible = false;
                textBoxNombre.Visible = false;

              
            }
            else if(comboBox1.SelectedItem=="Nombre")
            {
                panelSearch.Visible = true;
                radioButtonFemenino.Visible = false;
                radioButtonMasculino.Visible = false;
                textBoxNombre.Visible = true;
                textBoxNombre.Text = "";
                textBoxApellido.Visible = false;
            }
            else if(comboBox1.SelectedItem=="Apellido")
            {
                panelSearch.Visible = true;
                radioButtonFemenino.Visible = false;
                radioButtonMasculino.Visible = false;
                textBoxNombre.Visible = false;
                textBoxApellido.Visible = true;
                textBoxApellido.Text = "";
            }
            else if(comboBox1.SelectedItem=="Todo")
            {
                panelSearch.Visible = false;
                radioButtonFemenino.Visible = false;
                radioButtonMasculino.Visible = false;
                textBoxNombre.Visible = false;
                textBoxApellido.Visible = false;
                dataGridView1.DataSource = clienteRepository.ConsultarClientes();
            }

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Apellido", textBoxApellido.Text);
                dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
           
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Nombre", textBoxNombre.Text);
                dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
           
        }

        private void radioButtonMasculino_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Sexo", "M");
                dataGridView1.Columns["Id"].Visible = false;

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
          
        }

        private void radioButtonFemenino_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Sexo", "F");
                dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
            
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            //TOMO VALORES DE LA FILA SELECCIONADA 
            if (Convert.ToInt32( dataGridView1.SelectedRows[0].Cells["Id"].Value)==0)
            {

            }
            else
            {
              int IdCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                ServicioGrilla servicioGrilla = new ServicioGrilla();
               
                servicioGrilla.Filtro = true;
                servicioGrilla.IdCliente = IdCliente;
                servicioGrilla.ShowDialog();
            }
        }

        
    }
}
