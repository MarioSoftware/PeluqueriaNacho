using System;

namespace Entities
{
   public	class Turno
	{
		public int Id { get; set; }

		public DateTime FechaProgramada { get; set; }

		public string HoraProgramada { get; set; }

		public int IdCliente { get; set; }

		public string  Producto { get; set; }

		public string Senia { get; set; }

		public int MyProperty { get; set; }

		public decimal Monto { get; set; }

		public string Estado { get; set; }



	}
}
