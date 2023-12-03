using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DetalleCotizacionRepository : IGenericRepository<DetalleCotizacion>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DetalleCotizacionRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(DetalleCotizacion modelo)
        {
            _dbContext.DetalleCotizacions.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetalleCotizacion DetalleCotizacionEliminar = _dbContext.DetalleCotizacions.First(DetalleCotizacion => DetalleCotizacion.DetalleCotizacionId == id);
            _dbContext.DetalleCotizacions.Remove(DetalleCotizacionEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetalleCotizacion modelo)
        {
            _dbContext.DetalleCotizacions.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<DetalleCotizacion> Obtener(int id)
        {
            return await _dbContext.DetalleCotizacions.FindAsync(id);
        }

        public async Task<IQueryable<DetalleCotizacion>> ObtenerTodos()
        {
            IQueryable<DetalleCotizacion> queryDetalleCotizacionsSQL = _dbContext.DetalleCotizacions;
            return queryDetalleCotizacionsSQL;
        }
    }
}
