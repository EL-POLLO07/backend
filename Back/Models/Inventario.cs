namespace Back.Models//SERGIO RODRIGUEZ MENDOZA
{
    public class Inventario
    {
        public int IdMovimiento { get; set; }
        public ICollection<Productos> IdProducto{ get; set; }
        public string TipoMovimiento { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }
    }
}
