//Pablo//
using Back.DTOs;
using Back.Models;

namespace Back.Services
{
    public class PedidosService : IPedidosService
    {
        // Lista para simular base de datos
        private static List<Pedido> _pedidos = new();
        private static int _contadorId = 1;

        public async Task<object> CrearPedido(CrearPedidoDto dto)
        {
            var pedido = new Pedido
            {
                IdPedido = _contadorId++,
                IdCliente = dto.IdCliente,
                Fecha = DateTime.Now,
                Estado = "pendiente",
                Detalles = dto.Detalles.Select(d => new PedidoDetalle
                {
                    IdProducto = d.IdProducto,
                    Cantidad = d.Cantidad
                }).ToList()
            };

            _pedidos.Add(pedido);

            return new
            {
                mensaje = "Pedido registrado",
                idPedido = pedido.IdPedido
            };
        }
    }
}