using System.ComponentModel.DataAnnotations;

namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class DetalleVenta
    {
        [Key]
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public Ventas Venta { get; set; }
        public int IdProducto { get; set; }
        public Productos Producto { get; set; }
        public string Cantidad { get; set; }
        public double Subtotal { get; set; }

    }
}
