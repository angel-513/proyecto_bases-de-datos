using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface ICategoriaService
    {
        Task<bool> Insertar(CategoriaDepartamento modelo);
        Task<bool> Actualizar(CategoriaDepartamento modelo);
        Task<bool> Eliminar(int id);
        Task<CategoriaDepartamento> Obtener(int id);
        Task<IQueryable<CategoriaDepartamento>> ObtenerTodos();

        Task<ICollection<Producto>> ObtenerProductos(int CategoriaID);
    }
}