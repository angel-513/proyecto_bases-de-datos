using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Color
    {
        public Color()
        {
            EspecificacionProductos = new HashSet<EspecificacionProducto>();
        }

        public int ColorId { get; set; }
        public string NombreColor { get; set; } = null!;

        public virtual ICollection<EspecificacionProducto> EspecificacionProductos { get; set; }
    }
}
