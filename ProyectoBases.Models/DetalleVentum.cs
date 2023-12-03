using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class DetalleVentum
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public string ProductoId { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Producto Producto { get; set; } = null!;
        public virtual Ventum Venta { get; set; } = null!;
    }
}
