//Pablo//
using Back.DTOs;
using Back.Models;

namespace Back.Services
{
    public class PedidosService : IPedidosService
    {

        public async Task<object> CrearPedido(CrearPedidoDto dto)
        {
            return Task.CompletedTask;
        }
    }
}