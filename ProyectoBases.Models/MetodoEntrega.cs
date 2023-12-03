using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class MetodoEntrega
    {
        public MetodoEntrega()
        {
            Envios = new HashSet<Envio>();
            Facturas = new HashSet<Factura>();
            Venta = new HashSet<Ventum>();
        }

        public int MetodoEntregaId { get; set; }
        public string MetodoEntrega1 { get; set; } = null!;

        public virtual ICollection<Envio> Envios { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
