using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Direccion
    {
        public Direccion()
        {
            Clientes = new HashSet<Cliente>();
            Envios = new HashSet<Envio>();
            Proveedors = new HashSet<Proveedor>();
        }

        public int DireccionId { get; set; }
        public string Departamento { get; set; } = null!;
        public string Municipio { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Colonia { get; set; } = null!;
        public string Sector { get; set; } = null!;
        public string Casa { get; set; } = null!;
        public string? Referencia { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Envio> Envios { get; set; }
        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
