using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class DetalleDevolucion
    {
        public int DetalleDevolucionId { get; set; }
        public int DevolucionId { get; set; }
        public string ProductoId { get; set; } = null!;
        public decimal CantidadDevuelta { get; set; }
        public string? Motivo { get; set; }

        public virtual Devolucion Devolucion { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
