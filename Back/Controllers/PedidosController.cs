//Pablo//
using Microsoft.AspNetCore.Mvc;
using Back.Services;
using Back.DTOs;

namespace Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidosService _service;

        public PedidosController(IPedidosService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CrearPedido([FromBody] CrearPedidoDto dto)
        {
            var resultado = await _service.CrearPedido(dto);
            return Ok(resultado);
        }
    }
}
