namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public Ventas Venta { get; set; }
        public Productos Producto {get; set; }
        public string Cantidad { get; set; }
        public double Subtotal { get; set; }
        public ICollection<Productos> IdProducto { get; set; }

    }
}
