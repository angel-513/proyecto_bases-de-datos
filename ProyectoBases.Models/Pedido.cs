using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
            Envios = new HashSet<Envio>();
        }

        public int PedidoId { get; set; }
        public DateTime FechaPedido { get; set; }
        public string EstadoPedido { get; set; } = null!;
        public string ClienteId { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<Envio> Envios { get; set; }
    }
}
