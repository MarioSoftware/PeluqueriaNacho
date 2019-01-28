using System;
using System.Windows.Forms;
using Rules.Clientes;
using Entities;

namespace PeluqueriaNacho
{
    public partial class ClienteBuscar : Form
    {


        public ClienteLite clienteLite { get; set; }

        public ClienteBuscar()
        {
            InitializeComponent();
        }
        ClienteRepository clienteRepository = new ClienteRepository();

        public ClienteLite ObtenerClienteSeleccionado ()
        {
            ClienteLite clienteLite = new ClienteLite();

            clienteLite.Nombre =Convert.ToString( dataGridView1.SelectedRows[0].Cells["Nombre"].Value);
            clienteLite.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            clienteLite.Apellido = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Apellido"].Value);

            return clienteLite;
        } 

        private void ClienteBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarClientes();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["FechaDeNacimiento"].Visible = false;
                dataGridView1.Columns["Direccion"].Visible = false;
                dataGridView1.Columns["Localidad"].Visible = false;
                dataGridView1.Columns["Observacion"].Visible = false;
                dataGridView1.Columns["Ocupacion"].Visible = false;

                dataGridView1.Columns["Edad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["Sexo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception)
            {

                MessageBox.Show("ERORR  AL TRAER LOS CLIENTES DE LA BASE DE DATOS");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxSearch.SelectedItem == "Nombre")
            {
                textBoxNombre.Visible = true;
               
                textBoxNombre.Visible = true;
                textBoxNombre.Text = "";
                textBoxApellido.Visible = false;
            }
            else if (comboBoxSearch.SelectedItem == "Apellido")
            {
                textBoxApellido.Visible = true;
                textBoxApellido.Text = "";
                textBoxNombre.Visible = false;
                textBoxApellido.Visible = true;
            }
            else if (comboBoxSearch.SelectedItem == "Todo")
            {
               
                textBoxApellido.Visible = false;
                textBoxNombre.Visible = false;
                textBoxNombre.Visible = false;
                textBoxApellido.Visible = false;
                try
                {
                    dataGridView1.DataSource = clienteRepository.ConsultarClientes();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO AL TRAER LOS CLIENTES DE LA BASE DE DATOS");
                }
               
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Nombre", textBoxNombre.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
           
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Apellido", textBoxApellido.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
        }

        private void radioButtonM_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Sexo", "M");

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
        }

        private void radioButtonF_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clienteRepository.ConsultarPorFiltro("Sexo", "F");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL BUSCAR CLIENTE POR FILTRO");
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            //TOMO VALORES DE LA FILA SELECCIONADA Y CONSULTO CONTACTO RESPECTIVO
            try
            {
                clienteLite = ObtenerClienteSeleccionado();
                this.Close();
            }
            catch (Exception)
            {

                
            }
              
            
          
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
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

       
    }
}
