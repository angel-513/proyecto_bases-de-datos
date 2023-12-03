using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IProductoService
    {
        Task<bool> Insertar(Producto modelo);
        Task<bool> Actualizar(Producto modelo);
        Task<bool> Eliminar(string id);
        Task<Producto> Obtener(int id);
        Task<IQueryable<Producto>> ObtenerTodos();

        Task<Producto> ObtenerPorNombre(string nombreProducto);
        Task<double> ObtenerStockActual(string ProductoID);
        Task<Proveedor> ObtenerProveedor(string ProductoID);
        Task<double> ObtenerPrecioCompra(int nombreProducto);
        Task<double> ObtenerPrecioVenta(int nombreProducto);

    }
}
