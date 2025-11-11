namespace Back.Models//SAUL ANDRE ALVARADO ESPARZA
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public ICollection<Ventas> IdVenta {  get; set; }
    }
}
