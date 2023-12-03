using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DireccionRepository : IGenericRepository<Direccion>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DireccionRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Direccion modelo)
        {
            _dbContext.Direccions.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Direccion direccionEliminar = _dbContext.Direccions.First(direccion => direccion.DireccionId == id);
            _dbContext.Direccions.Remove(direccionEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Direccion modelo)
        {
            _dbContext.Direccions.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Direccion> Obtener(int id)
        {
            return await _dbContext.Direccions.FindAsync(id);
        }

        public async Task<IQueryable<Direccion>> ObtenerTodos()
        {
            IQueryable<Direccion> queryDireccionesSQL = _dbContext.Direccions;
            return queryDireccionesSQL;
        }
    }
}
