using ProyectoBases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.BLL.Service
{
    public interface IDetallePedidoService
    {
        Task<bool> Insertar(DetallePedido modelo);
        Task<bool> Eliminar(int id);
    }
}