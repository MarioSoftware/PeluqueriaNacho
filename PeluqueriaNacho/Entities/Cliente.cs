﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Sexo { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public int Edad { get; set; }

        public string Direccion { get; set; }

        public string Localidad { get; set; }

        public string Ocupacion { get; set; }

        public string Observacion { get; set; }

             


    }
}
