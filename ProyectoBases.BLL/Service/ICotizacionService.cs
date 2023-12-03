using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface ICotizacionService
    {
        Task<bool> Insertar(Cotizacion modelo);
        Task<bool> Eliminar(int id);
        Task<Cotizacion> Obtener(int id);
        Task<IQueryable<Cotizacion>> ObtenerTodos();

        Task<DateTime> ObtenerFechaCotizacion(int CotizacionID);
        Task<Cliente> ObtenerCliente(int CotizacionID);
        Task<ICollection<DetalleCotizacion>> ObtenerDetalles(int CotizacionID);
    }
}