using System;
using System.Collections.Generic;

namespace ProyectoBases.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            CategoriaDepartamentos = new HashSet<CategoriaDepartamento>();
        }

        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; } = null!;

        public virtual ICollection<CategoriaDepartamento> CategoriaDepartamentos { get; set; }
    }
}
