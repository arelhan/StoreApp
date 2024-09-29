using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { Id=1, Name="Computer", Price = 17_000},
                new Product() { Id=2, Name="Keyboard", Price = 1_000},
                new Product() { Id=3, Name="Mouse", Price = 500},
                new Product() { Id=4, Name="Monitor", Price = 10_000},
                new Product() { Id=5, Name="Deck", Price = 7_000}
            );
        }
    }
}