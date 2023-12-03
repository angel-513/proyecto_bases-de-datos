using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class CompraRepository : IGenericRepository<Compra>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public CompraRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Compra modelo)
        {
            _dbContext.Compras.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Compra CompraEliminar = _dbContext.Compras.First(Compra => Compra.CompraId == id);
            _dbContext.Compras.Remove(CompraEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Compra modelo)
        {
            _dbContext.Compras.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Compra> Obtener(int id)
        {
            return await _dbContext.Compras.FindAsync(id);
        }

        public async Task<IQueryable<Compra>> ObtenerTodos()
        {
            IQueryable<Compra> queryComprasSQL = _dbContext.Compras;
            return queryComprasSQL;
        }
    }
}
