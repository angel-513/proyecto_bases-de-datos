using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.DataContext
{
    public partial class bd_ferreteriaContext : DbContext
    {
        public bd_ferreteriaContext()
        {
        }

        public bd_ferreteriaContext(DbContextOptions<bd_ferreteriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriaDepartamento> CategoriaDepartamentos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Comentario> Comentarios { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<Cotizacion> Cotizacions { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<DetalleCompra> DetalleCompras { get; set; } = null!;
        public virtual DbSet<DetalleCotizacion> DetalleCotizacions { get; set; } = null!;
        public virtual DbSet<DetalleDevolucion> DetalleDevolucions { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<DetalleVentum> DetalleVenta { get; set; } = null!;
        public virtual DbSet<Devolucion> Devolucions { get; set; } = null!;
        public virtual DbSet<Direccion> Direccions { get; set; } = null!;
        public virtual DbSet<Empleo> Empleos { get; set; } = null!;
        public virtual DbSet<Envio> Envios { get; set; } = null!;
        public virtual DbSet<EspecificacionProducto> EspecificacionProductos { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Faq> Faqs { get; set; } = null!;
        public virtual DbSet<Garantium> Garantia { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<MetodoEntrega> MetodoEntregas { get; set; } = null!;
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; } = null!;
        public virtual DbSet<Notificacion> Notificacions { get; set; } = null!;
        public virtual DbSet<OfertaEspecial> OfertaEspecials { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<RecomendacionProducto> RecomendacionProductos { get; set; } = null!;
        public virtual DbSet<ReporteProblema> ReporteProblemas { get; set; } = null!;
        public virtual DbSet<SeguimientoCompra> SeguimientoCompras { get; set; } = null!;
        public virtual DbSet<SolicitudEmpleo> SolicitudEmpleos { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaDepartamento>(entity =>
            {
                entity.HasKey(e => e.CategoriaId)
                    .HasName("PK__Categori__F353C1C5098EE77B");

                entity.ToTable("CategoriaDepartamento");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.NombreCategoria).HasMaxLength(50);

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.CategoriaDepartamentos)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Categoria__Depar__5EBF139D");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("CLIENTE");

                entity.HasIndex(e => e.Telefono, "UQ__CLIENTE__4EC5048033DADC4F")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "UQ__CLIENTE__60695A1978FE7DDD")
                    .IsUnique();

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.Contrasena).HasMaxLength(50);

                entity.Property(e => e.Correo).HasMaxLength(50);

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Papellido)
                    .HasMaxLength(25)
                    .HasColumnName("PApellido");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(25)
                    .HasColumnName("PNombre");

                entity.Property(e => e.Sapellido)
                    .HasMaxLength(25)
                    .HasColumnName("SApellido");

                entity.Property(e => e.Snombre)
                    .HasMaxLength(25)
                    .HasColumnName("SNombre");

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.DireccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLIENTE__Direcci__6754599E");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("COLOR");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.NombreColor).HasMaxLength(15);
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.ToTable("Comentario");

                entity.Property(e => e.ComentarioId).HasColumnName("ComentarioID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaComentario).HasColumnType("datetime");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Texto).HasMaxLength(500);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comentari__Clien__1BC821DD");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comentari__Produ__1AD3FDA4");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.ToTable("COMPRA");

                entity.Property(e => e.CompraId).HasColumnName("CompraID");

                entity.Property(e => e.FechaCompra).HasColumnType("date");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.TotalCompra).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMPRA__Proveedo__778AC167");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.ToTable("COTIZACION");

                entity.Property(e => e.CotizacionId).HasColumnName("CotizacionID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaCotizacion).HasColumnType("date");

                entity.Property(e => e.TotalCotizacion).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Cotizacions)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COTIZACIO__Clien__03F0984C");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("DEPARTAMENTO");

                entity.Property(e => e.DepartamentoId).HasColumnName("DepartamentoID");

                entity.Property(e => e.NombreDepartamento).HasMaxLength(50);
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.ToTable("DetalleCompra");

                entity.Property(e => e.DetalleCompraId).HasColumnName("DetalleCompraID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CompraId).HasColumnName("CompraID");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__Compr__7A672E12");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__Produ__7B5B524B");
            });

            modelBuilder.Entity<DetalleCotizacion>(entity =>
            {
                entity.ToTable("DetalleCotizacion");

                entity.Property(e => e.DetalleCotizacionId).HasColumnName("DetalleCotizacionID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CotizacionId).HasColumnName("CotizacionID");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cotizacion)
                    .WithMany(p => p.DetalleCotizacions)
                    .HasForeignKey(d => d.CotizacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__Cotiz__06CD04F7");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetalleCotizacions)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleCo__Produ__07C12930");
            });

            modelBuilder.Entity<DetalleDevolucion>(entity =>
            {
                entity.ToTable("DetalleDevolucion");

                entity.Property(e => e.DetalleDevolucionId).HasColumnName("DetalleDevolucionID");

                entity.Property(e => e.CantidadDevuelta).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DevolucionId).HasColumnName("DevolucionID");

                entity.Property(e => e.Motivo).HasMaxLength(100);

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.HasOne(d => d.Devolucion)
                    .WithMany(p => p.DetalleDevolucions)
                    .HasForeignKey(d => d.DevolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleDe__Devol__14270015");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetalleDevolucions)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleDe__Produ__151B244E");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.ToTable("DetallePedido");

                entity.Property(e => e.DetallePedidoId).HasColumnName("DetallePedidoID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PedidoId).HasColumnName("PedidoID");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.PedidoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetallePe__Pedid__0D7A0286");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetallePe__Produ__0E6E26BF");
            });

            modelBuilder.Entity<DetalleVentum>(entity =>
            {
                entity.HasKey(e => e.DetalleVentaId)
                    .HasName("PK__DetalleV__340EED445341A302");

                entity.Property(e => e.DetalleVentaId).HasColumnName("DetalleVentaID");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VentaId).HasColumnName("VentaID");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleVe__Produ__74AE54BC");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleVe__Venta__73BA3083");
            });

            modelBuilder.Entity<Devolucion>(entity =>
            {
                entity.ToTable("Devolucion");

                entity.Property(e => e.DevolucionId).HasColumnName("DevolucionID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.EstadoDevolucion).HasMaxLength(20);

                entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Devolucions)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Devolucio__Clien__114A936A");
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.ToTable("DIRECCION");

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.Casa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Colonia).HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(50);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.Referencia).HasMaxLength(100);

                entity.Property(e => e.Sector)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Empleo>(entity =>
            {
                entity.ToTable("EMPLEO");

                entity.Property(e => e.EmpleoId).HasColumnName("EmpleoID");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Requisitos).HasMaxLength(100);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Envio>(entity =>
            {
                entity.ToTable("Envio");

                entity.Property(e => e.EnvioId).HasColumnName("EnvioID");

                entity.Property(e => e.DireccionEnvioId).HasColumnName("DireccionEnvioID");

                entity.Property(e => e.EstadoEnvio).HasMaxLength(20);

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.MetodoEntregaId).HasColumnName("MetodoEntregaID");

                entity.Property(e => e.PedidoId).HasColumnName("PedidoID");

                entity.HasOne(d => d.DireccionEnvio)
                    .WithMany(p => p.Envios)
                    .HasForeignKey(d => d.DireccionEnvioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Envio__Direccion__1F98B2C1");

                entity.HasOne(d => d.MetodoEntrega)
                    .WithMany(p => p.Envios)
                    .HasForeignKey(d => d.MetodoEntregaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Envio__MetodoEnt__208CD6FA");

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.Envios)
                    .HasForeignKey(d => d.PedidoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Envio__PedidoID__1EA48E88");
            });

            modelBuilder.Entity<EspecificacionProducto>(entity =>
            {
                entity.HasKey(e => e.ProductoId)
                    .HasName("PK__Especifi__A430AE83FA7157F5");

                entity.ToTable("EspecificacionProducto");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Altura).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Anchura).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.Largo).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.NumeroCatalogo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.EspecificacionProductos)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Especific__Color__59FA5E80");

                entity.HasOne(d => d.Producto)
                    .WithOne(p => p.EspecificacionProducto)
                    .HasForeignKey<EspecificacionProducto>(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Especific__Produ__59063A47");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("Factura");

                entity.Property(e => e.FacturaId).HasColumnName("FacturaID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaFactura).HasColumnType("date");

                entity.Property(e => e.MetodoEntregaId).HasColumnName("MetodoEntregaID");

                entity.Property(e => e.MetodoPagoId).HasColumnName("MetodoPagoID");

                entity.Property(e => e.TotalFactura).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VentaId).HasColumnName("VentaID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__Cliente__3587F3E0");

                entity.HasOne(d => d.MetodoEntrega)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.MetodoEntregaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__MetodoE__37703C52");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__MetodoP__367C1819");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Factura__VentaID__3864608B");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Faqid).HasColumnName("FAQID");

                entity.Property(e => e.Pregunta).HasMaxLength(500);

                entity.Property(e => e.Respuesta).HasMaxLength(1000);
            });

            modelBuilder.Entity<Garantium>(entity =>
            {
                entity.HasKey(e => e.GarantiaId)
                    .HasName("PK__Garantia__3552F814E778F82E");

                entity.Property(e => e.GarantiaId).HasColumnName("GarantiaID");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Garantia)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Garantia__Produc__17F790F9");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.ToTable("MARCA");

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.NombreMarca).HasMaxLength(40);
            });

            modelBuilder.Entity<MetodoEntrega>(entity =>
            {
                entity.ToTable("MetodoEntrega");

                entity.Property(e => e.MetodoEntregaId).HasColumnName("MetodoEntregaID");

                entity.Property(e => e.MetodoEntrega1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MetodoEntrega");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.ToTable("MetodoPago");

                entity.Property(e => e.MetodoPagoId).HasColumnName("MetodoPagoID");

                entity.Property(e => e.MetodoPago1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MetodoPago");
            });

            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.ToTable("Notificacion");

                entity.Property(e => e.NotificacionId).HasColumnName("NotificacionID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");

                entity.Property(e => e.Mensaje).HasMaxLength(500);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Notificacions)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Notificac__Clien__236943A5");
            });

            modelBuilder.Entity<OfertaEspecial>(entity =>
            {
                entity.HasKey(e => e.OfertaId)
                    .HasName("PK__OfertaEs__F2629BC979B7D414");

                entity.ToTable("OfertaEspecial");

                entity.Property(e => e.OfertaId).HasColumnName("OfertaID");

                entity.Property(e => e.Descuento).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FechaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.OfertaEspecials)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OfertaEsp__Produ__2645B050");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("Pedido");

                entity.Property(e => e.PedidoId).HasColumnName("PedidoID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.EstadoPedido).HasMaxLength(20);

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pedido__ClienteI__0A9D95DB");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("PRODUCTO");

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.NombreProducto).HasMaxLength(100);

                entity.Property(e => e.PrecioCompra).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PrecioVenta).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.StockActual).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StockMinimo).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.MarcaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTO__MarcaI__534D60F1");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCTO__Provee__52593CB8");

                entity.HasMany(d => d.Categoria)
                    .WithMany(p => p.Productos)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductoCategorium",
                        l => l.HasOne<CategoriaDepartamento>().WithMany().HasForeignKey("CategoriaId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__ProductoC__Categ__628FA481"),
                        r => r.HasOne<Producto>().WithMany().HasForeignKey("ProductoId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__ProductoC__Produ__619B8048"),
                        j =>
                        {
                            j.HasKey("ProductoId", "CategoriaId").HasName("PK__Producto__EB05929F98CDC325");

                            j.ToTable("ProductoCategoria");

                            j.IndexerProperty<string>("ProductoId").HasMaxLength(8).IsUnicode(false).HasColumnName("ProductoID").IsFixedLength();

                            j.IndexerProperty<int>("CategoriaId").HasColumnName("CategoriaID");
                        });
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("PROVEEDOR");

                entity.HasIndex(e => e.Telefono, "UQ__PROVEEDO__4EC5048099BD539F")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "UQ__PROVEEDO__60695A1965E96C5B")
                    .IsUnique();

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Correo).HasMaxLength(50);

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.NombreProveedor).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(15);

                entity.HasOne(d => d.Direccion)
                    .WithMany(p => p.Proveedors)
                    .HasForeignKey(d => d.DireccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROVEEDOR__Direc__4D94879B");
            });

            modelBuilder.Entity<RecomendacionProducto>(entity =>
            {
                entity.HasKey(e => e.RecomendacionId)
                    .HasName("PK__Recomend__104CC1EE22C79C0A");

                entity.ToTable("RecomendacionProducto");

                entity.Property(e => e.RecomendacionId).HasColumnName("RecomendacionID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID")
                    .IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.RecomendacionProductos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recomenda__Clien__31B762FC");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.RecomendacionProductos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recomenda__Produ__32AB8735");
            });

            modelBuilder.Entity<ReporteProblema>(entity =>
            {
                entity.HasKey(e => e.ReporteId)
                    .HasName("PK__ReporteP__0B29EA4E28F5A0FB");

                entity.ToTable("ReporteProblema");

                entity.Property(e => e.ReporteId).HasColumnName("ReporteID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.DescripcionProblema).HasMaxLength(1000);

                entity.Property(e => e.EstadoReporte).HasMaxLength(20);

                entity.Property(e => e.FechaReporte).HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ReporteProblemas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReportePr__Clien__2EDAF651");
            });

            modelBuilder.Entity<SeguimientoCompra>(entity =>
            {
                entity.HasKey(e => e.CompraId)
                    .HasName("PK__Seguimie__067DA7257530ECA7");

                entity.ToTable("SeguimientoCompra");

                entity.Property(e => e.CompraId)
                    .ValueGeneratedNever()
                    .HasColumnName("CompraID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaCompra).HasColumnType("datetime");

                entity.Property(e => e.TotalCompra).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SeguimientoCompras)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Seguimien__Clien__2A164134");

                entity.HasOne(d => d.Compra)
                    .WithOne(p => p.SeguimientoCompra)
                    .HasForeignKey<SeguimientoCompra>(d => d.CompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Seguimien__Compr__29221CFB");
            });

            modelBuilder.Entity<SolicitudEmpleo>(entity =>
            {
                entity.HasKey(e => e.SolicitudId)
                    .HasName("PK__Solicitu__85E95DA766C78A50");

                entity.ToTable("SolicitudEmpleo");

                entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.EmpleoId).HasColumnName("EmpleoID");

                entity.Property(e => e.Mensaje).HasMaxLength(100);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SolicitudEmpleos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__Clien__01142BA1");

                entity.HasOne(d => d.Empleo)
                    .WithMany(p => p.SolicitudEmpleos)
                    .HasForeignKey(d => d.EmpleoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__Emple__00200768");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.HasKey(e => e.VentaId)
                    .HasName("PK__VENTA__5B41514C2742B12B");

                entity.ToTable("VENTA");

                entity.Property(e => e.VentaId).HasColumnName("VentaID");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ClienteID")
                    .IsFixedLength();

                entity.Property(e => e.FechaVenta).HasColumnType("date");

                entity.Property(e => e.MetodoEntregaId).HasColumnName("MetodoEntregaID");

                entity.Property(e => e.MetodoPagoId).HasColumnName("MetodoPagoID");

                entity.Property(e => e.TotalVenta).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTA__ClienteID__6EF57B66");

                entity.HasOne(d => d.MetodoEntrega)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.MetodoEntregaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTA__MetodoEnt__6FE99F9F");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTA__MetodoPag__70DDC3D8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
