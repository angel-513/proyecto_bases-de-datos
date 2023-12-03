using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IDetalleCompraService
    {
        Task<bool> Insertar(DetalleCompra modelo);
        Task<bool> Eliminar(int id);
        Task<IQueryable<DetalleCompra>> ObtenerTodosFromVenta(int CompraID);
    }
}