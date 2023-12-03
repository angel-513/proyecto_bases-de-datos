using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class MetodoPagoRepository : IGenericRepository<MetodoPago>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public MetodoPagoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(MetodoPago modelo)
        {
            _dbContext.MetodoPagos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            MetodoPago MetodoPagoEliminar = _dbContext.MetodoPagos.First(MetodoPago => MetodoPago.MetodoPagoId == id);
            _dbContext.MetodoPagos.Remove(MetodoPagoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(MetodoPago modelo)
        {
            _dbContext.MetodoPagos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<MetodoPago> Obtener(int id)
        {
            return await _dbContext.MetodoPagos.FindAsync(id);
        }

        public async Task<IQueryable<MetodoPago>> ObtenerTodos()
        {
            IQueryable<MetodoPago> queryMetodoPagosQL = _dbContext.MetodoPagos;
            return queryMetodoPagosQL;
        }
    }
}