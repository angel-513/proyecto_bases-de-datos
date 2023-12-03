using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class CategoriaDepartamento
    {
        public CategoriaDepartamento()
        {
            Productos = new HashSet<Producto>();
        }

        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public int DepartamentoId { get; set; }

        public virtual Departamento Departamento { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
