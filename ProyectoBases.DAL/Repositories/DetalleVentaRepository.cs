using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DetalleVentaRepository : IGenericRepository<DetalleVentum>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DetalleVentaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(DetalleVentum modelo)
        {
            _dbContext.DetalleVenta.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetalleVentum DetalleVentumEliminar = _dbContext.DetalleVenta.First(DetalleVenta => DetalleVenta.DetalleVentaId == id);
            _dbContext.DetalleVenta.Remove(DetalleVentumEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetalleVentum modelo)
        {
            _dbContext.DetalleVenta.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<DetalleVentum> Obtener(int id)
        {
            return await _dbContext.DetalleVenta.FindAsync(id);
        }

        public async Task<IQueryable<DetalleVentum>> ObtenerTodos()
        {
            IQueryable<DetalleVentum> queryDetalleVentaSQL = _dbContext.DetalleVenta;
            return queryDetalleVentaSQL;
        }
    }
}
