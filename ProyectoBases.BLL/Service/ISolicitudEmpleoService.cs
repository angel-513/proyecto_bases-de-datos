using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface ISolicitudEmpleoService
    {
        Task<bool> Insertar(SolicitudEmpleo modelo);
        Task<bool> Eliminar(int id);
        Task<SolicitudEmpleo> Obtener(int id);
        Task<IQueryable<SolicitudEmpleo>> ObtenerTodos();

        Task<Cliente> ObtenerCliente(int SolicitudID);
    }
}
