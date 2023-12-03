using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class RecomendacionProducto
    {
        public int RecomendacionId { get; set; }
        public string ClienteId { get; set; } = null!;
        public string ProductoId { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
