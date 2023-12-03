using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class GarantiaRepository : IGenericRepository<Garantium>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public GarantiaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Garantium modelo)
        {
            _dbContext.Garantia.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Garantium GarantiumEliminar = _dbContext.Garantia.First(Garantia => Garantia.GarantiaId == id);
            _dbContext.Garantia.Remove(GarantiumEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Garantium modelo)
        {
            _dbContext.Garantia.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Garantium> Obtener(int id)
        {
            return await _dbContext.Garantia.FindAsync(id);
        }

        public async Task<IQueryable<Garantium>> ObtenerTodos()
        {
            IQueryable<Garantium> queryGarantiumesSQL = _dbContext.Garantia;
            return queryGarantiumesSQL;
        }
    }
}
