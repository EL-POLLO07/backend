namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public string Fecha { get; set; }
        public string Total { get; set; }
        public ICollection<Clientes> IdCliente { get; set; }
        public ICollection<Empleados> IdEmpleado { get; set; }
    }
}
