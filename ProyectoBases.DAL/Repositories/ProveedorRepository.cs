using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    class ProveedorRepository : IGenericRepository<Proveedor>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ProveedorRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Proveedor modelo)
        {
            _dbContext.Proveedors.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Proveedor proveedorEliminar = _dbContext.Proveedors.First(proveedor => proveedor.ProveedorId == id);
            _dbContext.Proveedors.Remove(proveedorEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Proveedor modelo)
        {
            _dbContext.Proveedors.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Proveedor> Obtener(int id)
        {
            return await _dbContext.Proveedors.FindAsync(id);
        }

        public async Task<IQueryable<Proveedor>> ObtenerTodos()
        {
            IQueryable<Proveedor> queryProveedorSQL = _dbContext.Proveedors;
            return queryProveedorSQL;
        }
    }

}