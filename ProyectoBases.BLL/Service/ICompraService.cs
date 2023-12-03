using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface ICompraService
    {
        Task<bool> Insertar(Compra modelo);
        Task<bool> Actualizar(Compra modelo);
        Task<bool> Eliminar(int id);
        Task<Compra> Obtener(int id);
        Task<IQueryable<Compra>> ObtenerTodos();

        Task<DateTime> ObtenerFechaCompra(int CompraID);
        Task<Proveedor> ObtenerProveedor(int CompraID);
        Task<ICollection<DetalleCompra>> ObtenerDetalles(int CompraID);
    }
}
