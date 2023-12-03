using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IDepartamentoService
    {
        Task<bool> Insertar(Departamento modelo);
        Task<bool> Actualizar(Departamento modelo);
        Task<bool> Eliminar(int id);
        Task<Departamento> Obtener(int id);
        Task<IQueryable<Departamento>> ObtenerTodos();

        Task<Departamento> ObtenerPorNombre(string NombreDepartamento);
        Task<ICollection<CategoriaDepartamento>> ObtenerCategorias(int DepartamentoID);
    }
}