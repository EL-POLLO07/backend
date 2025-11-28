//Pablo//
using Back.DTOs;

namespace Back.Services
{
    public interface IPedidosService
    {
        //Sergio Rodríguez Mendoza
        Task<int> CrearPedido(CrearPedidoDto dto);
        //Saul Alvarado//
        Task<bool> MarcarRecoleccion(int id);
        //Saul Alvarado//
        Task<bool> ConfirmarEntrega(int id);
        //Sergio Rodríguez Mendoza
        Task RegistrarPago(CrearPagoDto dto);
    }
}