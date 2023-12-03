using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class MetodoEntregaRepository : IGenericRepository<MetodoEntrega>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public MetodoEntregaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(MetodoEntrega modelo)
        {
            _dbContext.MetodoEntregas.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            MetodoEntrega MetodoEntregaEliminar = _dbContext.MetodoEntregas.First(MetodoEntrega => MetodoEntrega.MetodoEntregaId == id);
            _dbContext.MetodoEntregas.Remove(MetodoEntregaEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(MetodoEntrega modelo)
        {
            _dbContext.MetodoEntregas.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<MetodoEntrega> Obtener(int id)
        {
            return await _dbContext.MetodoEntregas.FindAsync(id);
        }

        public async Task<IQueryable<MetodoEntrega>> ObtenerTodos()
        {
            IQueryable<MetodoEntrega> queryMetodoEntregaSQL = _dbContext.MetodoEntregas;
            return queryMetodoEntregaSQL;
        }
    }
}