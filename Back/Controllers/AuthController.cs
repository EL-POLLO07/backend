using Back.Data;
using Back.Models;
using Back.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly PvmContext _context;
        public AuthController(PvmContext context) {  _context = context; }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest req)
        {
            var usuario = await _context.usuarios.FirstOrDefaultAsync(x => x.Correo == req.Correo);
            if (usuario == null)
                return BadRequest("Usuario no encontrado");
            var password_hashed = PasswordHasher.Hash(req.Contrasena);
            if (usuario.ContraseñaHash != password_hashed)
                return BadRequest("Contraseña incorrecta");
            return Ok();
        }

    }
}
