using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class ColorRepository : IGenericRepository<Color>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ColorRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Color modelo)
        {
            _dbContext.Colors.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Color colorEliminar = _dbContext.Colors.First(color => color.ColorId == id);
            _dbContext.Colors.Remove(colorEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Color modelo)
        {
            _dbContext.Colors.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Color> Obtener(int id)
        {
            return await _dbContext.Colors.FindAsync(id);
        }

        public async Task<IQueryable<Color>> ObtenerTodos()
        {
            IQueryable<Color> queryColoresSQL = _dbContext.Colors;
            return queryColoresSQL;
        }
    }
}
