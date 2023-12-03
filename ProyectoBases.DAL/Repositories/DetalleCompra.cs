using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DetalleCompraRepository : IGenericRepository<DetalleCompra>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DetalleCompraRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(DetalleCompra modelo)
        {
            _dbContext.DetalleCompras.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetalleCompra DetalleCompraEliminar = _dbContext.DetalleCompras.First(DetalleCompra => DetalleCompra.DetalleCompraId == id);
            _dbContext.DetalleCompras.Remove(DetalleCompraEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetalleCompra modelo)
        {
            _dbContext.DetalleCompras.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<DetalleCompra> Obtener(int id)
        {
            return await _dbContext.DetalleCompras.FindAsync(id);
        }

        public async Task<IQueryable<DetalleCompra>> ObtenerTodos()
        {
            IQueryable<DetalleCompra> queryDetalleComprasSQL = _dbContext.DetalleCompras;
            return queryDetalleComprasSQL;
        }
    }
}
