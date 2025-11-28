//Pablo//
using Back.DTOs;

namespace Back.Services
{
    public interface IPedidosService
    {
        Task<int> CrearPedido(CrearPedidoDto dto);
    }
}