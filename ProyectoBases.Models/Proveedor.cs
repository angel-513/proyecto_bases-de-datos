using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
            Productos = new HashSet<Producto>();
        }

        public int ProveedorId { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public int DireccionId { get; set; }

        public virtual Direccion Direccion { get; set; } = null!;
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
