using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DAL.Repositories.Interfaces
{
    public interface IEspecificacionesProductos
    {
        Task<bool> Insertar(EspecificacionProducto especificaciones);
        Task<bool> Actualizar(EspecificacionProducto especificacionesNuevas);
        Task<bool> Eliminar(string ProductoID);
        Task<EspecificacionProducto> ObtenerEspecificaciones(string ProductoID);
    }
}
