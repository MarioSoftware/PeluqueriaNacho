using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rules.Servicios;
using Entities;

namespace PeluqueriaNacho
{
    public partial class ProductoGrilla : Form
    {
       
        public DataGridView dtg { get; set; }
        ServiciosRepository servicioRepository = new ServiciosRepository();

        public ProductoGrilla()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoGrilla_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = servicioRepository.ConsultarProducto();
                dataGridView1.Columns["Id"].Visible=false;
                dataGridView1.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL TRAER PRODUCTOS DESDE LA BASE DE DATOS");
            }
           
        }

        private void buttonAgregarNuevo_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            productoForm.Nuevo = true;
            productoForm.ShowDialog();
            try
            {
                dataGridView1.DataSource = servicioRepository.ConsultarProducto();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL TRAER LOS PRODUCTOS DE LA BASE DE DATOS");
            }
           
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //TOMO VALORES DE LA FILA SELECCIONADA 
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) == 0)
            {

            }
            else
            {
                Producto producto= new Producto();
                producto.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                producto.Descripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                producto.Precio =Convert.ToDecimal( dataGridView1.SelectedRows[0].Cells["Precio"].Value.ToString());

               

                ////MANDO EL PRODUCTO AL FORM PRODUCTO
                ProductoForm productoForm = new ProductoForm();
                productoForm.productoP = producto;
                productoForm.Editar = true;
                productoForm.ShowDialog();
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value) == 0)
            {
                MessageBox.Show("Primero selecciona un Producto, luego preciona eliminar");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro que quieres elinar este producto?", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int IdProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    servicioRepository.EliminarProducto(IdProducto);
                    dataGridView1.DataSource = servicioRepository.ConsultarProducto();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                
            }
        }
    }
}
