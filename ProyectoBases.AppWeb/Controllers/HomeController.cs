using Microsoft.AspNetCore.Mvc;
using ProyectoBases.AppWeb.Models;
using ProyectoBases.AppWeb.Models.ViewModels;
using ProyectoBases.BLL.Service;
using ProyectoBases.Models;
using System.Diagnostics;
using System.Globalization;

namespace ProyectoBases.AppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IDireccionService _direccionService;

        public HomeController(IClienteService clienteService, IDireccionService direccionService)
        {
            _clienteService = clienteService;
            _direccionService = direccionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListarClientes()
        {
            IQueryable<Cliente> queryClientes = await _clienteService.ObtenerTodos();
            List<VMCliente> lista = queryClientes.Select(x => new VMCliente
            {
                ClienteId = x.ClienteId,
                Pnombre = x.Pnombre,
                Snombre = x.Snombre,
                Papellido = x.Papellido,
                Sapellido = x.Sapellido,
                DireccionId = x.DireccionId,
                Telefono = x.Telefono,
                Correo = x.Correo,
                Contrasena = x.Contrasena,
                FechaNacimiento = x.FechaNacimiento.ToString("dd/MM/yyyy")
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, lista);
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerDireccionFromCliente(string ClienteID)
        {
            Direccion direccion = await _clienteService.ObtenerDireccion(ClienteID);

            return StatusCode(StatusCodes.Status200OK, direccion);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCliente([FromBody] VMCliente modelo)
        {
            Cliente nuevoCliente = new Cliente()
            {
                Pnombre = modelo.Pnombre,
                Snombre = modelo.Snombre,
                Papellido = modelo.Papellido,
                Sapellido = modelo.Sapellido,
                DireccionId = modelo.DireccionId,
                Telefono = modelo.Telefono,
                Correo = modelo.Correo,
                Contrasena = modelo.Contrasena,
                FechaNacimiento = DateTime.ParseExact(modelo.FechaNacimiento, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-PE"))
            };

            bool respuesta = await _clienteService.Insertar(nuevoCliente);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarCliente([FromBody] VMCliente modelo)
        {
            Cliente clienteActualizado = new Cliente()
            {
                ClienteId = modelo.ClienteId,
                Pnombre = modelo.Pnombre,
                Snombre = modelo.Snombre,
                Papellido = modelo.Papellido,
                Sapellido = modelo.Sapellido,
                DireccionId = modelo.DireccionId,
                Telefono = modelo.Telefono,
                Correo = modelo.Correo,
                Contrasena = modelo.Contrasena,
                FechaNacimiento = DateTime.ParseExact(modelo.FechaNacimiento, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("es-PE"))
            };

            bool respuesta = await _clienteService.Actualizar(clienteActualizado);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        [HttpDelete]
        public async Task<IActionResult> EliminarCliente(string id)
        {
            bool respuesta = await _clienteService.Eliminar(id);

            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
