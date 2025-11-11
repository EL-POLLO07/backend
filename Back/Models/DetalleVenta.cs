namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public ICollection<Ventas> IdVenta { get; set; }
        public ICollection<Productos> IdProducto { get; set; }
        public string Cantidad { get; set; }
        public double Subtotal { get; set; }

    }
}
