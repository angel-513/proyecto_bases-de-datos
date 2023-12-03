using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IProveedornService
    {
        Task<bool> Insertar(Proveedor modelo);
        Task<bool> Actualizar(Proveedor modelo);
        Task<bool> Eliminar(int id);
        Task<Proveedor> Obtener(int id);
        Task<IQueryable<Proveedor>> ObtenerTodos();

        Task<Proveedor> ObtenerPorNombre(string nombreProveedor);
    }
}
