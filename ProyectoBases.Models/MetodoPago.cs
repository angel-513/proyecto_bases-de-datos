using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Facturas = new HashSet<Factura>();
            Venta = new HashSet<Ventum>();
        }

        public int MetodoPagoId { get; set; }
        public string MetodoPago1 { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
