using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int CompraId { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal TotalCompra { get; set; }
        public int ProveedorId { get; set; }

        public virtual Proveedor Proveedor { get; set; } = null!;
        public virtual SeguimientoCompra SeguimientoCompra { get; set; } = null!;
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
