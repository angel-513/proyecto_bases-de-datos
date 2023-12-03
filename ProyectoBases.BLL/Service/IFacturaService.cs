using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IFacturaService
    {
        Task<bool> Insertar(Compra modelo);
        Task<bool> Actualizar(Compra modelo);
        Task<bool> Eliminar(int id);
        Task<Compra> Obtener(int id);
        Task<IQueryable<Compra>> ObtenerTodos();
    }
}
