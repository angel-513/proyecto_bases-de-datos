using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DAL.Repositories
{
    public interface IClienteRepository
    {
        Task<bool> Insertar(Cliente Cliente);
        Task<bool> Actualizar(Cliente Cliente);
        Task<bool> Eliminar(string ClienteID);
        Task<Cliente> Obtener(string ClienteID);
        Task<IQueryable<Cliente>> ObtenerTodos();
    }
}