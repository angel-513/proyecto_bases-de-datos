using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Factura
    {
        public int FacturaId { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public string ClienteId { get; set; } = null!;
        public int MetodoPagoId { get; set; }
        public int MetodoEntregaId { get; set; }
        public int VentaId { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual MetodoEntrega MetodoEntrega { get; set; } = null!;
        public virtual MetodoPago MetodoPago { get; set; } = null!;
        public virtual Ventum Venta { get; set; } = null!;
    }
}
