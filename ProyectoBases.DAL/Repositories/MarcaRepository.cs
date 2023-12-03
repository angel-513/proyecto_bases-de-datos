using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    class MarcaRepository : IGenericRepository<Marca>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public MarcaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Marca modelo)
        {
            _dbContext.Marcas.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Marca marcaEliminar = _dbContext.Marcas.First(marca => marca.MarcaId == id);
            _dbContext.Marcas.Remove(marcaEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Marca modelo)
        {
            _dbContext.Marcas.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Marca> Obtener(int id)
        {
            return await _dbContext.Marcas.FindAsync(id);
        }

        public async Task<IQueryable<Marca>> ObtenerTodos()
        {
            IQueryable<Marca> queryMarcasSQL = _dbContext.Marcas;
            return queryMarcasSQL;
        }
    }
}