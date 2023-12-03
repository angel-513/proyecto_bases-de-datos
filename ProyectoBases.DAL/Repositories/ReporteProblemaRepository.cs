using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class ReporteProblemaRepository : IGenericRepository<ReporteProblema>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ReporteProblemaRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(ReporteProblema modelo)
        {
            _dbContext.ReporteProblemas.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            ReporteProblema ReporteProblemaEliminar = _dbContext.ReporteProblemas.First(ReporteProblema => ReporteProblema.ReporteId == id);
            _dbContext.ReporteProblemas.Remove(ReporteProblemaEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(ReporteProblema modelo)
        {
            _dbContext.ReporteProblemas.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<ReporteProblema> Obtener(int id)
        {
            return await _dbContext.ReporteProblemas.FindAsync(id);
        }

        public async Task<IQueryable<ReporteProblema>> ObtenerTodos()
        {
            IQueryable<ReporteProblema> queryReportesProblemasSQL = _dbContext.ReporteProblemas;
            return queryReportesProblemasSQL;
        }
    }
}
