using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class EnvioRepository : IGenericRepository<Envio>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public EnvioRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Envio modelo)
        {
            _dbContext.Envios.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Envio EnvioEliminar = _dbContext.Envios.First(Envio => Envio.EnvioId == id);
            _dbContext.Envios.Remove(EnvioEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Envio modelo)
        {
            _dbContext.Envios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Envio> Obtener(int id)
        {
            return await _dbContext.Envios.FindAsync(id);
        }

        public async Task<IQueryable<Envio>> ObtenerTodos()
        {
            IQueryable<Envio> queryEnviosSQL = _dbContext.Envios;
            return queryEnviosSQL;
        }
    }
}
