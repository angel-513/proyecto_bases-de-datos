using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class DetallePedidoRepository : IGenericRepository<DetallePedido>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public DetallePedidoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(DetallePedido modelo)
        {
            _dbContext.DetallePedidos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetallePedido DetallePedidoEliminar = _dbContext.DetallePedidos.First(DetallePedido => DetallePedido.DetallePedidoId == id);
            _dbContext.DetallePedidos.Remove(DetallePedidoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetallePedido modelo)
        {
            _dbContext.DetallePedidos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<DetallePedido> Obtener(int id)
        {
            return await _dbContext.DetallePedidos.FindAsync(id);
        }

        public async Task<IQueryable<DetallePedido>> ObtenerTodos()
        {
            IQueryable<DetallePedido> queryDetallePedidosSQL = _dbContext.DetallePedidos;
            return queryDetallePedidosSQL;
        }
    }
}
