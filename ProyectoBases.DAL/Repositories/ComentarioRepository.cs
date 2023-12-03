using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class ComentarioRepository : IGenericRepository<Comentario>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ComentarioRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Comentario modelo)
        {
            _dbContext.Comentarios.Update(modelo);
            
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Comentario ComentarioEliminar = _dbContext.Comentarios.First(Comentario => Comentario.ComentarioId == id);
            _dbContext.Comentarios.Remove(ComentarioEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Comentario modelo)
        {
            _dbContext.Comentarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Comentario> Obtener(int id)
        {
            return await _dbContext.Comentarios.FindAsync(id);
        }

        public async Task<IQueryable<Comentario>> ObtenerTodos()
        {
            IQueryable<Comentario> queryComentariosSQL = _dbContext.Comentarios;
            return queryComentariosSQL;
        }
    }
}
