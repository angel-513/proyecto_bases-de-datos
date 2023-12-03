using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class DetallePedido
    {
        public int DetallePedidoId { get; set; }
        public int PedidoId { get; set; }
        public string ProductoId { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Pedido Pedido { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
