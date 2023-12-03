using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    class ProductoRepository : IProductoRepository
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ProductoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }
        public async Task<bool> Actualizar(Producto modelo)
        {
            _dbContext.Productos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(string id)
        {
            Producto productoEliminar = _dbContext.Productos.First(producto => producto.ProductoId == id);
            _dbContext.Productos.Remove(productoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Producto modelo)
        {
            _dbContext.Productos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Producto> Obtener(string id)
        {
            return await _dbContext.Productos.FindAsync(id);
        }

        public async Task<IQueryable<Producto>> ObtenerTodos()
        {
            IQueryable<Producto> queryProductosSQL = _dbContext.Productos;
            return queryProductosSQL;
        }
    }
}