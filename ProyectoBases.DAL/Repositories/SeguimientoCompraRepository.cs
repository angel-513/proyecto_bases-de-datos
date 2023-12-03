using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class SeguimientoCompraRepository : IGenericRepository<SeguimientoCompra>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public SeguimientoCompraRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(SeguimientoCompra modelo)
        {
            _dbContext.SeguimientoCompras.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            SeguimientoCompra SeguimientoCompraEliminar = _dbContext.SeguimientoCompras.First(SeguimientoCompra => SeguimientoCompra.CompraId == id);
            _dbContext.SeguimientoCompras.Remove(SeguimientoCompraEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(SeguimientoCompra modelo)
        {
            _dbContext.SeguimientoCompras.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<SeguimientoCompra> Obtener(int id)
        {
            return await _dbContext.SeguimientoCompras.FindAsync(id);
        }

        public async Task<IQueryable<SeguimientoCompra>> ObtenerTodos()
        {
            IQueryable<SeguimientoCompra> querySeguimientosCompraSQL = _dbContext.SeguimientoCompras;
            return querySeguimientosCompraSQL;
        }
    }
}
