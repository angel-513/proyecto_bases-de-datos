using ProyectoBases.Models;

namespace ProyectoBases.AppWeb.Models.ViewModels
{
    public class VMCliente
    {
        public VMCliente()
        {
            Comentarios = new HashSet<Comentario>();
            Cotizacions = new HashSet<Cotizacion>();
            Devolucions = new HashSet<Devolucion>();
            Facturas = new HashSet<Factura>();
            Notificacions = new HashSet<Notificacion>();
            Pedidos = new HashSet<Pedido>();
            RecomendacionProductos = new HashSet<RecomendacionProducto>();
            SeguimientoCompras = new HashSet<SeguimientoCompra>();
            SolicitudEmpleos = new HashSet<SolicitudEmpleo>();
            Venta = new HashSet<Ventum>();
        }

        public string ClienteId { get; set; } = null!;
        public string Pnombre { get; set; } = null!;
        public string? Snombre { get; set; }
        public string Papellido { get; set; } = null!;
        public string? Sapellido { get; set; }
        public int DireccionId { get; set; }
        public string Telefono { get; set; } = null!;
        public string? Correo { get; set; }
        public string Contrasena { get; set; } = null!;
        public string? FechaNacimiento { get; set; }

        public virtual Direccion Direccion { get; set; } = null!;
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<Devolucion> Devolucions { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Notificacion> Notificacions { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<RecomendacionProducto> RecomendacionProductos { get; set; }
        public virtual ICollection<SeguimientoCompra> SeguimientoCompras { get; set; }
        public virtual ICollection<SolicitudEmpleo> SolicitudEmpleos { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
