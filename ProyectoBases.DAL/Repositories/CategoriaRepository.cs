using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class CategoriaRepository : IGenericRepository<CategoriaDepartamento>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public CategoriaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(CategoriaDepartamento modelo)
        {
            _dbContext.CategoriaDepartamentos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            CategoriaDepartamento CategoriaDepartamentoEliminar = _dbContext.CategoriaDepartamentos.First(categoria => categoria.CategoriaId == id);
            _dbContext.CategoriaDepartamentos.Remove(CategoriaDepartamentoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(CategoriaDepartamento modelo)
        {
            _dbContext.CategoriaDepartamentos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CategoriaDepartamento> Obtener(int id)
        {
            return await _dbContext.CategoriaDepartamentos.FindAsync(id);
        }

        public async Task<IQueryable<CategoriaDepartamento>> ObtenerTodos()
        {
            IQueryable<CategoriaDepartamento> queryCategoriaDepartamentosSQL = _dbContext.CategoriaDepartamentos;
            return queryCategoriaDepartamentosSQL;
        }
    }
}
