using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class SolicitudEmpleoRepository : IGenericRepository<SolicitudEmpleo>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public SolicitudEmpleoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(SolicitudEmpleo modelo)
        {
            _dbContext.SolicitudEmpleos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            SolicitudEmpleo SolicitudEmpleoEliminar = _dbContext.SolicitudEmpleos.First(solicitu => solicitu.SolicitudId == id);
            _dbContext.SolicitudEmpleos.Remove(SolicitudEmpleoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(SolicitudEmpleo modelo)
        {
            _dbContext.SolicitudEmpleos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<SolicitudEmpleo> Obtener(int id)
        {
            return await _dbContext.SolicitudEmpleos.FindAsync(id);
        }

        public async Task<IQueryable<SolicitudEmpleo>> ObtenerTodos()
        {
            IQueryable<SolicitudEmpleo> querySolicitudEmpleoesSQL = _dbContext.SolicitudEmpleos;
            return querySolicitudEmpleoesSQL;
        }
    }
}
