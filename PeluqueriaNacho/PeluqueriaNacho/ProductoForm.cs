using System;
 
using System.Windows.Forms;
using Entities;
using Rules.Servicios;

namespace PeluqueriaNacho
{
    public partial class ProductoForm : Form
    {
        ServiciosRepository servicioRepository = new ServiciosRepository();

        public Producto productoP { get; set; }
        Producto producto = new Producto();
        public bool Editar { get; set; }
        public bool Nuevo { get; set; }

        public ProductoForm()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(Nuevo)
            {
                if(string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
                {
                    MessageBox.Show("DEBES PONER UNA DESCRIPCION PARA EL PRODUCTO !");
                }
                else if(string.IsNullOrWhiteSpace(textBoxPrecio.Text)){
                    MessageBox.Show("DEBES PONER UN PRECIO PARA EL PRODUCTO !");
                }
                else
                {
                   
                    producto.Descripcion = Convert.ToString(textBoxDescripcion.Text.ToUpper());
                    try
                    {
                        producto.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                        try
                        {
                            servicioRepository.InsertarProducto(producto);
                            this.Close();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("ERROR AL GUARDAR PRODUCTO");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Igresa un precio Válido para el producto !");
                    }
                  
                    

                }

            }
            else if (Editar)
            {
                producto.Id = productoP.Id;
                producto.Descripcion = Convert.ToString(textBoxDescripcion.Text.ToUpper());
                producto.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                try
                {
                    servicioRepository.EditarProducto(producto);
                    this.Close();
                  
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL EDITAR SERVICIO");
                }
            }
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            if (Editar)
            {
                textBoxDescripcion.Text = productoP.Descripcion;
                textBoxPrecio.Text =Convert.ToString(productoP.Precio);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
