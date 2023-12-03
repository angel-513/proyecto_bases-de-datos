using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Garantium
    {
        public int GarantiaId { get; set; }
        public string ProductoId { get; set; } = null!;
        public int DuracionMeses { get; set; }

        public virtual Producto Producto { get; set; } = null!;
    }
}
