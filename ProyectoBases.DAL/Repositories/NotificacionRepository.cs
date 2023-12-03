using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class NotificacionRepository : IGenericRepository<Notificacion>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public NotificacionRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Notificacion modelo)
        {
            _dbContext.Notificacions.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Notificacion NotificacionEliminar = _dbContext.Notificacions.First(Notificacion => Notificacion.NotificacionId == id);
            _dbContext.Notificacions.Remove(NotificacionEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Notificacion modelo)
        {
            _dbContext.Notificacions.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Notificacion> Obtener(int id)
        {
            return await _dbContext.Notificacions.FindAsync(id);
        }

        public async Task<IQueryable<Notificacion>> ObtenerTodos()
        {
            IQueryable<Notificacion> queryNotificacionesSQL = _dbContext.Notificacions;
            return queryNotificacionesSQL;
        }
    }
}
