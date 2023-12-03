using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Comentarios = new HashSet<Comentario>();
            DetalleCompras = new HashSet<DetalleCompra>();
            DetalleCotizacions = new HashSet<DetalleCotizacion>();
            DetalleDevolucions = new HashSet<DetalleDevolucion>();
            DetallePedidos = new HashSet<DetallePedido>();
            DetalleVenta = new HashSet<DetalleVentum>();
            Garantia = new HashSet<Garantium>();
            OfertaEspecials = new HashSet<OfertaEspecial>();
            RecomendacionProductos = new HashSet<RecomendacionProducto>();
            Categoria = new HashSet<CategoriaDepartamento>();
        }

        public string ProductoId { get; set; } = null!;
        public string NombreProducto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal StockActual { get; set; }
        public decimal StockMinimo { get; set; }
        public int ProveedorId { get; set; }
        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; } = null!;
        public virtual Proveedor Proveedor { get; set; } = null!;
        public virtual EspecificacionProducto EspecificacionProducto { get; set; } = null!;
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleCotizacion> DetalleCotizacions { get; set; }
        public virtual ICollection<DetalleDevolucion> DetalleDevolucions { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
        public virtual ICollection<Garantium> Garantia { get; set; }
        public virtual ICollection<OfertaEspecial> OfertaEspecials { get; set; }
        public virtual ICollection<RecomendacionProducto> RecomendacionProductos { get; set; }

        public virtual ICollection<CategoriaDepartamento> Categoria { get; set; }
    }
}
