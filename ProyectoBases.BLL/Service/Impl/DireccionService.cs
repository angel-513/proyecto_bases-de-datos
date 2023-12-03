using ProyectoBases.DAL.Repositories;
using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public class DireccionService : IDireccionService
    {
        private readonly IGenericRepository<Direccion> _direccionRepo;

        public DireccionService(IGenericRepository<Direccion> direccionRepo)
        {
            _direccionRepo = direccionRepo;
        }

        public async Task<bool> Actualizar(Direccion modelo)
        {
            return await _direccionRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _direccionRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Direccion modelo)
        {
            return await _direccionRepo.Insertar(modelo);
        }

        public Task<Direccion> Obtener(int id)
        {
            return _direccionRepo.Obtener(id);
        }

        public async Task<Direccion> ObtenerPorDepartamento(string departamento)
        {
            IQueryable<Direccion> queryDireccionesSQL = await _direccionRepo.ObtenerTodos();
            Direccion direccionBuscada = queryDireccionesSQL.Where(direccion => direccion.Departamento == departamento).FirstOrDefault();
            return direccionBuscada;
        }

        public Task<IQueryable<Direccion>> ObtenerTodos()
        {
            return _direccionRepo.ObtenerTodos();
        }
    }
}
