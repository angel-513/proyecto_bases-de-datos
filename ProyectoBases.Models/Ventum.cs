using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Ventum
    {
        public Ventum()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
            Facturas = new HashSet<Factura>();
        }

        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public string ClienteId { get; set; } = null!;
        public int MetodoEntregaId { get; set; }
        public int MetodoPagoId { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual MetodoEntrega MetodoEntrega { get; set; } = null!;
        public virtual MetodoPago MetodoPago { get; set; } = null!;
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
