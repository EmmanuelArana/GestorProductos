using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimeraAppMAUIBlazor.Class.Producto
{
    public class ProductoListCLS
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
