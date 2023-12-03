using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Comentario
    {
        public int ComentarioId { get; set; }
        public string ProductoId { get; set; } = null!;
        public string ClienteId { get; set; } = null!;
        public DateTime FechaComentario { get; set; }
        public string Texto { get; set; } = null!;
        public int Calificacion { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
