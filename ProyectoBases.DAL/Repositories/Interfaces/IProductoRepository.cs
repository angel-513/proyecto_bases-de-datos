using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DAL.Repositories
{
    public interface IProductoRepository
    {
        Task<bool> Insertar(Producto producto);
        Task<bool> Actualizar(Producto producto);
        Task<bool> Eliminar(string ProductoID);
        Task<Producto> Obtener(string ProductoID);
        Task<IQueryable<Producto>> ObtenerTodos();
    }
}