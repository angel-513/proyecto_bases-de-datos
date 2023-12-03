using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class CotizacionRepository : IGenericRepository<Cotizacion>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public CotizacionRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Cotizacion modelo)
        {
            _dbContext.Cotizacions.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Cotizacion CotizacionEliminar = _dbContext.Cotizacions.First(Cotizacion => Cotizacion.CotizacionId == id);
            _dbContext.Cotizacions.Remove(CotizacionEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Cotizacion modelo)
        {
            _dbContext.Cotizacions.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cotizacion> Obtener(int id)
        {
            return await _dbContext.Cotizacions.FindAsync(id);
        }

        public async Task<IQueryable<Cotizacion>> ObtenerTodos()
        {
            IQueryable<Cotizacion> queryCotizacionesSQL = _dbContext.Cotizacions;
            return queryCotizacionesSQL;
        }
    }
}
