using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class OfertaEspecial
    {
        public int OfertaId { get; set; }
        public string ProductoId { get; set; } = null!;
        public decimal Descuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public virtual Producto Producto { get; set; } = null!;
    }
}
