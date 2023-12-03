using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Envio
    {
        public int EnvioId { get; set; }
        public int PedidoId { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string? EstadoEnvio { get; set; }
        public int DireccionEnvioId { get; set; }
        public int MetodoEntregaId { get; set; }

        public virtual Direccion DireccionEnvio { get; set; } = null!;
        public virtual MetodoEntrega MetodoEntrega { get; set; } = null!;
        public virtual Pedido Pedido { get; set; } = null!;
    }
}
