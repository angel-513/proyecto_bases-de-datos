using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Devolucion
    {
        public Devolucion()
        {
            DetalleDevolucions = new HashSet<DetalleDevolucion>();
        }

        public int DevolucionId { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string ClienteId { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual ICollection<DetalleDevolucion> DetalleDevolucions { get; set; }
    }
}
