using ProyectoBases.DAL.Repositories;
using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IGenericRepository<CategoriaDepartamento> _categoriaRepo;
        private readonly IGenericRepository<Departamento> _departamentoRepo;

        public CategoriaService(IGenericRepository<CategoriaDepartamento> categoriaRepo, IGenericRepository<Departamento> depaRepo)
        {
            _categoriaRepo = categoriaRepo;
            _departamentoRepo = depaRepo;
        }

        public async Task<bool> Actualizar(CategoriaDepartamento modelo)
        {
            return await _categoriaRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _categoriaRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(CategoriaDepartamento modelo)
        {
            return await _categoriaRepo.Insertar(modelo);
        }

        public Task<CategoriaDepartamento> Obtener(int id)
        {
            return _categoriaRepo.Obtener(id);
        }

        public async Task<ICollection<Producto>> ObtenerProductos(int CategoriaID)
        {
            CategoriaDepartamento categoria = await _categoriaRepo.Obtener(CategoriaID);
            return categoria.Productos;
        }

        public Task<IQueryable<CategoriaDepartamento>> ObtenerTodos()
        {
            return _categoriaRepo.ObtenerTodos();
        }
    }
}