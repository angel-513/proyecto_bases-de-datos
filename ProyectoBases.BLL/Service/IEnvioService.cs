using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IEnvioService
    {
        Task<bool> Insertar(Ventum modelo);
        Task<bool> Eliminar(int id);
        Task<Ventum> Obtener(int id);
        Task<IQueryable<Ventum>> ObtenerTodos();

        Task<DateTime> ObtenerFechaEnvio(int EnvioID);
        Task<Cliente> ObtenerCliente(int EnvioID);
        Task<Pedido> ObtenerPedido(int EnvioID);
        Task<string> ObtenerEstado(int EnvioID);
    }
}