using JuegotecH.DTOs;
using JuegotecH.Services;
using Microsoft.AspNetCore.Mvc;

namespace JuegotecH.Controllers
{
    [ApiController]
    [Route("productos-controller")]

    public class ProductosController : ControllerBase
    {
        ProductosService service = new();

        [HttpGet]
        [Route("lista-productos")] //nombre de la ruta.

        public async Task<IActionResult> ListaProductos()
        {
            var response = await service.ListaProductos();
            return new JsonResult(response) { StatusCode = response.Code };
        }

        [HttpPost]
        [Route("crear-producto")] //nombre de la ruta.

        public async Task<IActionResult> CrearProducto([FromBody] ProductosDTO data)
        {
            var response = await service.CrearProducto(data);
            return new JsonResult(response) { StatusCode = response.Code };
        }


    }
}
