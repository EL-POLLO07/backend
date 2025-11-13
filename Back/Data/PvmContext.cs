using Back.Models; //Alan y Cami:)
using Microsoft.EntityFrameworkCore;

namespace Back.Data
{
    public class PvmContext:DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }   
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<DetalleVenta> Detalle { get; set; }
        public DbSet<Empleados> empleados { get; set; }
        public DbSet<Inventario> inventario { get; set; }
        public DbSet<Pagos> pagos { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<Ventas> ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)=> options.UseSqlServer("Server=\\SQLEXPRESS; Database= base_de_datos; Trusted_Connection = True; User= sa; Password= ; TrustServerCertificate= True ")

        
      
    }
}
