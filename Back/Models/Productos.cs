namespace Back.Models//SERGIO RODRIGUEZ MENDOZA
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public ICollection<Categorias> IdCategoria { get; set; }
        public ICollection<Proveedores> IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }
    }
}
