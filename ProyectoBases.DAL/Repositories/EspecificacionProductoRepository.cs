using ProyectoBases.DAL.DataContext;
using ProyectoBases.DAL.Repositories.Interfaces;
using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DAL.Repositories
{
    public class EspecificacionProductoRepository : IEspecificacionesProductos
    {
        private readonly bd_ferreteriaContext _dbContext;

        public EspecificacionProductoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(EspecificacionProducto modelo)
        {
            _dbContext.EspecificacionProductos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Eliminar(string ProductoID)
        {
            EspecificacionProducto especificacionesEliminar = _dbContext.EspecificacionProductos.First(espe => espe.ProductoId == ProductoID);
            _dbContext.EspecificacionProductos.Remove(especificacionesEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(EspecificacionProducto especificaciones)
        {
            _dbContext.EspecificacionProductos.Add(especificaciones);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<EspecificacionProducto> ObtenerEspecificaciones(string ProductoID)
        {
            Producto producto = await _dbContext.Productos.FindAsync(ProductoID);
            return producto.EspecificacionProducto;
        }
    }
}
