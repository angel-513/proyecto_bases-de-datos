using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IEmpleoService
    {
        Task<bool> Insertar(Empleo modelo);
        Task<bool> Eliminar(int id);
        Task<Empleo> Obtener(int id);
        Task<IQueryable<Empleo>> ObtenerTodos();

        Task<ICollection<SolicitudEmpleo>> ObtenerSolicitudes(int EmpleoID);
    }
}
