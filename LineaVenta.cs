using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteSupermercado
{
    internal class LineaVenta
    {
        public int IdProducto { get; set; }
        public string Clave { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
