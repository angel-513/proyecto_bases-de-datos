using ProyectoBases.DAL.Repositories;
using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service.Impl
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepo;

        public ClienteService(IClienteRepository clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }

        public async Task<bool> Actualizar(Cliente modelo)
        {
            return await _clienteRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(string id)
        {
            return await _clienteRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            return await _clienteRepo.Insertar(modelo);
        }

        public async Task<Cliente> Obtener(string id)
        {
            return await _clienteRepo.Obtener(id);
        }

        public async Task<Direccion> ObtenerDireccion(string ClienteID)
        {
            Cliente cliente = await _clienteRepo.Obtener(ClienteID);
            return cliente.Direccion;
        }

        public async Task<IQueryable<Cliente>> ObtenerTodos()
        {
            return await _clienteRepo.ObtenerTodos();
        }
    }
}
