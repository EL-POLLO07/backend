namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }
        public int IdEmpleado { get; set; }
        public Empleados Empleado { get; set; }
        public string Fecha { get; set; }
        public string Total { get; set; }
        public ICollection<Pagos> IdPago { get; set; }
        public ICollection<DetalleVenta> IdDetalleVenta { get; set; }
    }
}