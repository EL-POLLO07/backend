//Pablo//
using Back.Data;
using Back.DTOs;
using Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Services
{
    public class PedidosService : IPedidosService
    {
        private readonly PvmContext _context;
        public PedidosService(PvmContext context)
        {
            _context = context;
        }
        public async Task<int> CrearPedido(CrearPedidoDto dto)
        {
            //valida el stock 
            foreach (var det in dto.Detalles)
            {
                var inventario = await _context.inventario.FirstOrDefaultAsync(i => i.IdProducto == det.IdProducto);

                if (inventario == null)
                    throw new Exception($"El producto {det.IdProducto} no existe en el inventario");

                if (inventario.Cantidad < det.Cantidad)
                    throw new Exception($"No hay suficiente stock del producto {det.IdProducto}");

            }
            //Crear venta
            var venta = new Ventas
            {
                IdCliente = dto.IdCliente,
                IdEmpleado = 1,
                Fecha = DateTime.Now,
                Total = 0m
            };
            _context.ventas.Add(venta);
            await _context.SaveChangesAsync();

            decimal totalVenta = 0;
            foreach(var det in dto.Detalles)
            {
                var producto = await _context.productos.FirstOrDefaultAsync(p => p.IdProducto == det.IdProducto);
                var inventario = await _context.inventario.FirstOrDefaultAsync(i => i.IdProducto == det.IdProducto);

                decimal precio = producto.Precio;
                    
            }
        
        }

    }
}