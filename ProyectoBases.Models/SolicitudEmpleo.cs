using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class SolicitudEmpleo
    {
        public int SolicitudId { get; set; }
        public int EmpleoId { get; set; }
        public string ClienteId { get; set; } = null!;
        public string? Mensaje { get; set; }
        public bool? EstadoSolicitud { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Empleo Empleo { get; set; } = null!;
    }
}
