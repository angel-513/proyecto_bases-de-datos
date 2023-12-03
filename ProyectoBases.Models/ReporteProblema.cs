using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class ReporteProblema
    {
        public int ReporteId { get; set; }
        public string ClienteId { get; set; } = null!;
        public DateTime FechaReporte { get; set; }
        public string DescripcionProblema { get; set; } = null!;
        public string EstadoReporte { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;
    }
}
