//Pablo//
using Back.DTOs;

namespace Back.Services
{
    public interface IPedidosService
    {
        Task<object> CrearPedido(CrearPedidoDto dto);
    }
}