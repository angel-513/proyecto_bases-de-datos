using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IVentaService
    {
        Task<bool> Insertar(Ventum modelo);
        Task<bool> Eliminar(int id);
        Task<Ventum> Obtener(int id);
        Task<IQueryable<Ventum>> ObtenerTodos();

        Task<DateTime> ObtenerFechaVenta(int VentaID);
        Task<MetodoEntrega> ObtenerMetodoEntrega(int VentaID);
        Task<MetodoPago> ObtenerMetodoPago(int VentaID);
        Task<Cliente> ObtenerCliente(int VentaID);
        Task<ICollection<DetalleVentum>> ObtenerDetalles(int VentaID);
    }
}