using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IClienteService
    {
        Task<bool> Insertar(Cliente modelo);
        Task<bool> Actualizar(Cliente modelo);
        Task<bool> Eliminar(string id);
        Task<Cliente> Obtener(string id);
        Task<IQueryable<Cliente>> ObtenerTodos();

        Task<Direccion> ObtenerDireccion(string ClienteID);
    }
}