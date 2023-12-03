using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.Models;

namespace ProyectoBases.DAL.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly bd_ferreteriaContext _dbContext;

        public ClienteRepository(bd_ferreteriaContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Actualizar(Cliente modelo)
        {
            _dbContext.Clientes.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(string id)
        {
            Cliente ClienteEliminar = _dbContext.Clientes.First(Cliente => Cliente.ClienteId == id);
            _dbContext.Clientes.Remove(ClienteEliminar);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            _dbContext.Clientes.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> Obtener(string id)
        {
            return await _dbContext.Clientes.FindAsync(id);
        }

        public async Task<IQueryable<Cliente>> ObtenerTodos()
        {
            IQueryable<Cliente> queryClientesSQL = _dbContext.Clientes;
            return queryClientesSQL;
        }
    }
}
