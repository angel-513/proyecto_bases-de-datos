using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class SeguimientoCompra
    {
        public int CompraId { get; set; }
        public string ClienteId { get; set; } = null!;
        public DateTime FechaCompra { get; set; }
        public decimal TotalCompra { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Compra Compra { get; set; } = null!;
    }
}
