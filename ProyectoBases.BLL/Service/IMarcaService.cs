using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IMarcaService
    {
        Task<bool> Insertar(Marca modelo);
        Task<bool> Actualizar(Marca modelo);
        Task<bool> Eliminar(int id);
        Task<Marca> Obtener(int id);
        Task<IQueryable<Marca>> ObtenerTodos();

        Task<Marca> ObtenerPorNombre(string nombreMarca);
    }
}
