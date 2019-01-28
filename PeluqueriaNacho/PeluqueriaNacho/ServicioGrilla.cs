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
    public partial class ServicioGrilla : Form
    {
        ServiciosRepository servicioRepository = new ServiciosRepository();
        public bool Filtro { get; set; }
        public int IdCliente  { get; set; }
        public decimal Abono { get; set; }
        public DataTable ServiciosActuales { get; set; }

        public ServicioGrilla()
        {
            InitializeComponent();
        }

        private void ServicioGrilla_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
            if(Filtro)
            {
                //FILTRO POR CLIENTE
                try
                {
                    ServiciosActuales= servicioRepository.ConsultarServicioFiltro(IdCliente);
                    dataGridView1.DataSource = ServiciosActuales;
                    dataGridView1.Columns["Detalles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Acredito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Debe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["NombreTarjeta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Id"].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER SERVICIOS DE LA BASE DE DATOS");
                }

            }

            else
            {
                // TRAIGO TODOS LOS SERVICIOS
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicio();
                    dataGridView1.DataSource = ServiciosActuales;
                    dataGridView1.Columns["Detalles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Acredito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Debe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["NombreTarjeta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Id"].Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER LOS SERVICIOS DE LA BASE DE DATOS");
                }
            }
           
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ObtenerFechaInicio(DateTime inicio)
        {
            string fecha = inicio.ToString("dd/MM/yyyy");
          
          
            string fechaInicio = fecha + " 00:00:00";
         
           
            return fechaInicio;
        }

        public string ObtenerFechaFin(DateTime fin)
        {
            string fecha = fin.ToString("dd/MM/yyyy");


            string fechaFin = fecha + " 23:59:59";
           
            return fechaFin;
        }

        public  decimal ObtenerGanancia()
        {

            decimal ganancia = 0;
            foreach (DataRow row in ServiciosActuales.Rows)
            {


                
                ganancia += Convert.ToDecimal(row["Total"]);
           
                
            }
            return ganancia;
        }

        public decimal ObtenerDeuda()
        {

            decimal ganancia = 0;
            foreach (DataRow row in ServiciosActuales.Rows)
            {


                ganancia += Convert.ToDecimal(row["Debe"]);
             
            }
            return ganancia;
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

        public Producto ObtenerProductoPorId()
        {
            var datatableProducto = servicioRepository.ConsultarProducto();
            int IdProducto = Convert.ToInt32(comboBoxProductos.SelectedValue);

            foreach (DataRow row in datatableProducto.Rows)
            {
                if (Convert.ToInt32(row["Id"]) == IdProducto)
                {

                    Producto producto = new Producto()
                    {
                        Id = Convert.ToInt32(comboBoxProductos.SelectedValue),
                        Precio = Convert.ToDecimal(row["Precio"]),
                        Descripcion = Convert.ToString(row["Descripcion"])

                    };

                    return producto;

                }
            }
            return null;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

            string fechaInicio = ObtenerFechaInicio(dateTimePicker1.Value);
            string fechaFin = ObtenerFechaFin(dateTimePicker1.Value);
            try
            {
                ServiciosActuales = servicioRepository.ConsultarServicioFiltroFecha(fechaInicio, fechaFin);
                dataGridView1.DataSource = ServiciosActuales;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL BUSCAR TRABAJOS CON LA FECHA SELECCIONADA");
            }
           
        }

        private void buttonCalcularGanancia_Click(object sender, EventArgs e)
        {
            int ganancia= Convert.ToInt32(ObtenerGanancia());
            textBoxGanancia.Text =Convert.ToString( ganancia);
            if(ganancia>0)
            {
                buttonAplicarGasto.Visible = true;
                textBoxGasto.Visible = true;
                labelGastos.Visible = true;
             
            }
            else
            {
                buttonAplicarGasto.Visible = false;
                textBoxGasto.Visible = false;
                labelGastos.Visible = false;
                textBoxGasto.Text = "";
            }
        }
               
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

            DateTime desde = dateTimePicker1.Value;
            DateTime hasta = dateTimePickerHasta.Value;

            if(desde<hasta)
            {
                string fechaInicio = ObtenerFechaInicio(desde);
                string fechaFin = ObtenerFechaFin(hasta);
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicioFiltroFecha(fechaInicio, fechaFin);
                    dataGridView1.DataSource = ServiciosActuales;
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL TRAER LA LISTA DE TRABAJOS DE LA BASE DE DATOS");
                }
            
            }
            else
            {
                MessageBox.Show("ERROR  La fecha de INICIO debe ser anterior a la fecha de FIN, para traer la lista deseada !!");
            }
           

            



        }

        private void comboBoxProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Producto productoInstancia = ObtenerProductoPorId();
            if (productoInstancia == null)
            {
                MessageBox.Show("ERROR AL RECUPERAR PRECIO Y NOMBRE DE ESTE PRODUCTO");
            }
            else
            {
                ServiciosActuales= servicioRepository.ConsultarServicioFiltroProducto(productoInstancia.Id);
                dataGridView1.DataSource = ServiciosActuales;
            }
        }

        private void buttonCalcularDeuda_Click(object sender, EventArgs e)
        {
            int deuda = Convert.ToInt32(ObtenerDeuda());
           textBoxDeuda.Text =Convert.ToString( deuda);
        }

        private void comboBoxFiltroTrabajos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFiltroTrabajos.SelectedItem == "TODOS")
            {
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicio();
                    dataGridView1.DataSource = ServiciosActuales;
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL TRAER TODOS LOS TRABAJOS DEE LA BASE DE DATOS");
                }


            }
            else if(comboBoxFiltroTrabajos.SelectedItem=="EFECTIVO")
            {
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicioFiltroFormaPago("EFECTIVO");
                    dataGridView1.DataSource = ServiciosActuales;
            }
                catch (Exception)
            {
                MessageBox.Show("ERROR AL TRAER LOS TRABAJOS CON PAGO EN EFECTIVO DESDE LA BASE DE DATOS ");
            }
        }
            else if (comboBoxFiltroTrabajos.SelectedItem == "TARGETA")
            {
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicioFiltroFormaPago("TARGETA");
                    dataGridView1.DataSource = ServiciosActuales;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER LOS TRABAJOS CON PAGO EN TARGETA DESDE LA BASE DE DATOS ");
                }
            }
            else if (comboBoxFiltroTrabajos.SelectedItem == "DEUDAS")
            {
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicioFiltroDeuda();
                    dataGridView1.DataSource = ServiciosActuales;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER LOS TRABAJOS CON DEUDA DESDE LA BASE DE DATOS ");
                }
            }
            else if (comboBoxFiltroTrabajos.SelectedItem == "CREDITO")
            {
                try
                {
                    ServiciosActuales = servicioRepository.ConsultarServicioFiltroDeuda();
                    dataGridView1.DataSource = ServiciosActuales;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL TRAER LOS TRABAJOS A CREDITO DESDE LA BASE DE DATOS ");
                }
            }
        }

        private void buttonAplicarGasto_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxGasto.Text))
            {
                MessageBox.Show("INGRESA UN VALOR EN EL CAMPO DE GASTOS");
                              
            }
            else
            {
                try
                {
                    decimal total = ObtenerGanancia();
                    decimal gastos = Convert.ToDecimal(textBoxGasto.Text);

                    if (gastos < total)
                    {
                        textBoxGanancia.Text = Convert.ToString(total - gastos);

                    }
                    else
                    {
                        MessageBox.Show("LOS GASTOS SON MAYORES A LA GANANCIA, APLICA UN GASTO MENOR A LA GANANCIA PARA OBTENER UN VALOR VÁLIDO");
                    }



                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR, INTENTA ESCRIBIR EL GASTO EN NUMEROS SIN LETRAS ");
                }
            }
          

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            try
            {
               decimal debe =Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Debe"].Value);
                if(debe>0)
                {
                    groupBoxPagar.Visible = true;
                    buttonPagar.Visible = true;
                  
                }
                else
                {
                    groupBoxPagar.Visible = false;
                    buttonPagar.Visible = false;
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        public void AbonoDeudaTerminado()
        {
            buttonPagar.Visible = false;
            textBoxPagar.Text = "";
            groupBoxPagar.Visible = false;
            ServiciosActuales = servicioRepository.ConsultarServicio();
            dataGridView1.DataSource = ServiciosActuales;
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            decimal abono = 0;
                decimal debe = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Debe"].Value);
                decimal total = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["Total"].Value);
                int IdServicio= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            decimal totalReal = total + debe;
            try
            {
                  abono = Convert.ToDecimal(textBoxPagar.Text);
                if (abono > debe || abono<0)
                {
                    MessageBox.Show("Ingresa un monto inferior o igual a la Deuda de $" + debe);
                }
                else
                {
                    try
                    {
                        total += abono;
                        debe -= abono;
                        servicioRepository.AbonarDeuda(IdServicio, debe,total);
                        AbonoDeudaTerminado();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL ABONAR DEUDA, REINTENTA NUEVAMENTE Y SI EL PROBLEMA PERXISTE LLAMA A MARIO PEDERNERA 3544 659058");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa un monto valido !");

            }
         
            
         

            

        }
    }
}
