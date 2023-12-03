using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class PedidoRepository : IGenericRepository<Pedido>
    {
        private readonly bd_ferreteriaContext _dbContext;

        public PedidoRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Pedido modelo)
        {
            _dbContext.Pedidos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Pedido PedidoEliminar = _dbContext.Pedidos.First(Pedido => Pedido.PedidoId == id);
            _dbContext.Pedidos.Remove(PedidoEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Pedido modelo)
        {
            _dbContext.Pedidos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Pedido> Obtener(int id)
        {
            return await _dbContext.Pedidos.FindAsync(id);
        }

        public async Task<IQueryable<Pedido>> ObtenerTodos()
        {
            IQueryable<Pedido> queryPedidosSQL = _dbContext.Pedidos;
            return queryPedidosSQL;
        }
    }
}
