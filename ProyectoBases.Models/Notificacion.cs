using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Notificacion
    {
        public int NotificacionId { get; set; }
        public string ClienteId { get; set; } = null!;
        public string Mensaje { get; set; } = null!;
        public DateTime FechaNotificacion { get; set; }
        public bool Leida { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
    }
}
