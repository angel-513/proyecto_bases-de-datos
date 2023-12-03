using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class RecomendacionProductoRepository : IGenericRepository<RecomendacionProducto>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public RecomendacionProductoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(RecomendacionProducto modelo)
        {
            _dbContext.RecomendacionProductos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            RecomendacionProducto RecomendacionProductoEliminar = _dbContext.RecomendacionProductos.First(RecomendacionProducto => RecomendacionProducto.RecomendacionId == id);
            _dbContext.RecomendacionProductos.Remove(RecomendacionProductoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(RecomendacionProducto modelo)
        {
            _dbContext.RecomendacionProductos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<RecomendacionProducto> Obtener(int id)
        {
            return await _dbContext.RecomendacionProductos.FindAsync(id);
        }

        public async Task<IQueryable<RecomendacionProducto>> ObtenerTodos()
        {
            IQueryable<RecomendacionProducto> queryRecomendacionsProductosSQL = _dbContext.RecomendacionProductos;
            return queryRecomendacionsProductosSQL;
        }
    }
}
