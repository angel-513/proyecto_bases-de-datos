using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DAL.Repositories
{
    public class FacturaRepository : IGenericRepository<Factura>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public FacturaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Factura modelo)
        {
            _dbContext.Facturas.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Factura facturaEliminar = _dbContext.Facturas.First(factura => factura.FacturaId == id);
            _dbContext.Facturas.Remove(facturaEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Factura modelo)
        {
            _dbContext.Facturas.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Factura> Obtener(int id)
        {
            return await _dbContext.Facturas.FindAsync(id);
        }

        public async Task<IQueryable<Factura>> ObtenerTodos()
        {
            IQueryable<Factura> queryFacturasSQL = _dbContext.Facturas;
            return queryFacturasSQL;
        }
    }
}
