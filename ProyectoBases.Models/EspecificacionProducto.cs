using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class EspecificacionProducto
    {
        public string ProductoId { get; set; } = null!;
        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Anchura { get; set; }
        public string? NumeroCatalogo { get; set; }
        public int ColorId { get; set; }
        public bool? ProductoGravado { get; set; }

        public virtual Color Color { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
