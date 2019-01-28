using System;
using System.Windows.Forms;
using Rules.Turnos;


namespace PeluqueriaNacho
{

    public partial class TurnoGrilla : Form
    {



        public TurnoGrilla()
        {
            InitializeComponent();
        }
        TurnosRepository turnoRepository = new TurnosRepository();
        public string ObtenerFechaInicio(DateTime inicio)
        {
            string fecha = inicio.ToString("MM/dd/yyyy");


            string fechaInicio = fecha + " 00:00:00";


            return fechaInicio;
        }

        public string ObtenerFechaFin(DateTime fin)
        {
            string fecha = fin.ToString("dd/MM/yyyy");


            string fechaFin = fecha + " 23:59:59";

            return fechaFin;
        }

        private void TurnoGrilla_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource= turnoRepository.ConsultarTurnos();
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al traer los turnos de la base de datos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            string fechaInicio = ObtenerFechaInicio(dateTimePicker1.Value);
            string fechaFin = ObtenerFechaFin(dateTimePicker1.Value);
            try
            {
                dataGridView1.DataSource=turnoRepository.ConsultarTurnoFiltroFecha(fechaInicio, fechaFin);
                 
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL BUSCAR TURNOS CON LA FECHA SELECCIONADA");
            }
        }

        private void comboBoxFiltroTrabajos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFiltroTurnos.SelectedItem == "VENCIDOS")
            {
                try
                {
                    dataGridView1.DataSource = turnoRepository.ConsultarTurnoFiltroEstado("VENCIDO");

                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL TRAER TODOS LOS TURNOS VENCIDOS DESDE LA BASE DE DATOS");
                }


            }
            else  if (comboBoxFiltroTurnos.SelectedItem == "VIGENTES")
            {
                try
                {
                    dataGridView1.DataSource = turnoRepository.ConsultarTurnoFiltroEstado("VIGENTE");

                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL TRAER TODOS LOS TURNOS VIGENTES DESDE LA BASE DE DATOS");
                }
            }
            else if (comboBoxFiltroTurnos.SelectedItem == "TODOS")
            {
                try
                {
                    dataGridView1.DataSource = turnoRepository.ConsultarTurnos();

                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR AL TRAER TODOS LOS TURNOS  DESDE LA BASE DE DATOS");
                }
            }
        }
    }
}
