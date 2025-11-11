namespace Back.Models //SERGIO RODRIGUEZ MENDOZA
{
    public class Pagos
    {
        public int IdPago {  get; set; }
        public ICollection<Ventas> IdVenta { get; set; }
        public string MetodoPago { get; set; }
        public double Monto { get; set; }
        public string Fecha { get; set; }
    }
}
