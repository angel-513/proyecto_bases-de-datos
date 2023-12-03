using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class EmpleoRepository : IGenericRepository<Empleo>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public EmpleoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Empleo modelo)
        {
            _dbContext.Empleos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Empleo EmpleoEliminar = _dbContext.Empleos.First(Empleo => Empleo.EmpleoId == id);
            _dbContext.Empleos.Remove(EmpleoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Empleo modelo)
        {
            _dbContext.Empleos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Empleo> Obtener(int id)
        {
            return await _dbContext.Empleos.FindAsync(id);
        }

        public async Task<IQueryable<Empleo>> ObtenerTodos()
        {
            IQueryable<Empleo> queryEmpleosSQL = _dbContext.Empleos;
            return queryEmpleosSQL;
        }
    }
}
