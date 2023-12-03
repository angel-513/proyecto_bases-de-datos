using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Cotizacion
    {
        public Cotizacion()
        {
            DetalleCotizacions = new HashSet<DetalleCotizacion>();
        }

        public int CotizacionId { get; set; }
        public string ClienteId { get; set; } = null!;
        public DateTime FechaCotizacion { get; set; }
        public decimal TotalCotizacion { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual ICollection<DetalleCotizacion> DetalleCotizacions { get; set; }
    }
}
