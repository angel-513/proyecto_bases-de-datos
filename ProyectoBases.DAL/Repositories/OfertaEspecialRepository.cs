using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class OfertaEspecialRepository : IGenericRepository<OfertaEspecial>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public OfertaEspecialRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(OfertaEspecial modelo)
        {
            _dbContext.OfertaEspecials.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            OfertaEspecial OfertaEspecialEliminar = _dbContext.OfertaEspecials.First(OfertaEspecial => OfertaEspecial.OfertaId == id);
            _dbContext.OfertaEspecials.Remove(OfertaEspecialEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(OfertaEspecial modelo)
        {
            _dbContext.OfertaEspecials.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<OfertaEspecial> Obtener(int id)
        {
            return await _dbContext.OfertaEspecials.FindAsync(id);
        }

        public async Task<IQueryable<OfertaEspecial>> ObtenerTodos()
        {
            IQueryable<OfertaEspecial> queryOfertasEspecialesSQL = _dbContext.OfertaEspecials;
            return queryOfertasEspecialesSQL;
        }
    }
}
