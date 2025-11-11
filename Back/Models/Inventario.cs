using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Back.Models//SERGIO RODRIGUEZ MENDOZA
{
    public class Inventario
    {
        public int IdMovimiento { get; set; }
        public int IdProducto { get; set; }
        public Productos Producto { get; set; }
        public string TipoMovimiento { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }
    }
}