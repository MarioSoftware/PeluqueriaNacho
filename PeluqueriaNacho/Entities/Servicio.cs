using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Servicio
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public int IdProducto { get; set; }

        public DateTime FechaHora { get; set; }
                
        public decimal Total { get; set; }

        public string FormaDePago { get; set; }

        public string NombreTarjeta { get; set; }

        public string Acredito { get; set; }

        public decimal Debe { get; set; }

        public string Detalles { get; set; }

       

    }
}
