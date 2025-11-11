namespace Back.Models//SERGIO RODRIGUEZ MENDOZA
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public Categorias Categoria { get; set; }
        public int IdProveedor { get; set; }
        public Proveedores Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }
        public ICollection<Inventario> IdInventario { get; set; }
        public ICollection<DetalleVenta> IdDetalleVenta { get; set; }
    }
}