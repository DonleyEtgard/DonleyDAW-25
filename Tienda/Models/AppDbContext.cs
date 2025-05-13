using System.Data.Entity;

namespace WinFormsApp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }

        public AppDbContext()
            : base("Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Producto ---
            modelBuilder.Entity<Producto>()
                .HasRequired(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaCodigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasRequired(p => p.Proveedor)
                .WithMany(p => p.Productos)
                .HasForeignKey(p => p.ProveedorCodigo)
                .WillCascadeOnDelete(false);

            // --- Factura ---
            modelBuilder.Entity<Factura>()
                .HasKey(f => f.Numero);

            modelBuilder.Entity<Factura>()
                .HasMany(f => f.Detalles)
                .WithRequired(d => d.Factura)
                .HasForeignKey(d => d.FacturaId)
                .WillCascadeOnDelete(true); // Elimina detalles si se elimina la factura

            // --- DetalleFactura ---
            modelBuilder.Entity<DetalleFactura>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<DetalleFactura>()
                .HasRequired(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.ProductoId)
                .WillCascadeOnDelete(false); // No eliminar producto al eliminar detalle
        }
    }
}