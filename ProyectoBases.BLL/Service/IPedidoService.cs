using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IPedidoService
    {
        Task<bool> Insertar(Ventum modelo);
        Task<bool> Eliminar(int id);
        Task<Ventum> Obtener(int id);
        Task<IQueryable<Ventum>> ObtenerTodos();

        Task<DateTime> ObtenerFechapedido(int PedidoID);
        Task<Cliente> ObtenerCliente(int PedidoID);
        Task<ICollection<DetalleVentum>> ObtenerDetalles(int PedidoID);
        Task<string> ObtenerEstado(int PedidoID);
    }
}