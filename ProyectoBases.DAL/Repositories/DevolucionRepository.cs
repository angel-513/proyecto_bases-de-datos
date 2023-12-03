using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DevolucionRepository : IGenericRepository<Devolucion>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DevolucionRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Devolucion modelo)
        {
            _dbContext.Devolucions.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Devolucion DevolucionEliminar = _dbContext.Devolucions.First(Devolucion => Devolucion.DevolucionId == id);
            _dbContext.Devolucions.Remove(DevolucionEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Devolucion modelo)
        {
            _dbContext.Devolucions.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Devolucion> Obtener(int id)
        {
            return await _dbContext.Devolucions.FindAsync(id);
        }

        public async Task<IQueryable<Devolucion>> ObtenerTodos()
        {
            IQueryable<Devolucion> queryDevolucionesSQL = _dbContext.Devolucions;
            return queryDevolucionesSQL;
        }
    }
}
