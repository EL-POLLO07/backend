namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class Pagos
    {
        public int IdPago {  get; set; }
        public int IdVenta { get; set; }
        public Ventas Venta { get; set; }
        public string MetodoPago { get; set; }
        public double Monto { get; set; }
        public string Fecha { get; set; }
    }
}
