using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class VentaRepository : IGenericRepository<Ventum>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public VentaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Ventum modelo)
        {
            _dbContext.Venta.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Ventum VentaEliminar = _dbContext.Venta.First(Venta => Venta.VentaId == id);
            _dbContext.Venta.Remove(VentaEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Ventum modelo)
        {
            _dbContext.Venta.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Ventum> Obtener(int id)
        {
            return await _dbContext.Venta.FindAsync(id);
        }

        public async Task<IQueryable<Ventum>> ObtenerTodos()
        {
            IQueryable<Ventum> queryVentasSQL = _dbContext.Venta;
            return queryVentasSQL;
        }
    }
}