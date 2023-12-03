using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IDireccionService
    {
        Task<bool> Insertar(Direccion modelo);
        Task<bool> Actualizar(Direccion modelo);
        Task<bool> Eliminar(int id);
        Task<Direccion> Obtener(int id);
        Task<IQueryable<Direccion>> ObtenerTodos();

        //Aqui va la logica de negocio, las consultas SQL por ejemplo
        //Ejemplo:
        Task<Direccion> ObtenerPorDepartamento(string departamento);
    }
}
