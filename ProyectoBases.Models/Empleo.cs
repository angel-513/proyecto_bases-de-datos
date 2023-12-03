using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Empleo
    {
        public Empleo()
        {
            SolicitudEmpleos = new HashSet<SolicitudEmpleo>();
        }

        public int EmpleoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Requisitos { get; set; }

        public virtual ICollection<SolicitudEmpleo> SolicitudEmpleos { get; set; }
    }
}
