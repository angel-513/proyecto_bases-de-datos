using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    class DepartamentoRepository : IGenericRepository<Departamento>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DepartamentoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Departamento modelo)
        {
            _dbContext.Departamentos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Departamento DepartamentoEliminar = _dbContext.Departamentos.First(Departamento => Departamento.DepartamentoId == id);
            _dbContext.Departamentos.Remove(DepartamentoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Departamento modelo)
        {
            _dbContext.Departamentos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Departamento> Obtener(int id)
        {
            return await _dbContext.Departamentos.FindAsync(id);
        }

        public async Task<IQueryable<Departamento>> ObtenerTodos()
        {
            IQueryable<Departamento> queryDepartamentosSQL = _dbContext.Departamentos;
            return queryDepartamentosSQL;
        }
    }
}