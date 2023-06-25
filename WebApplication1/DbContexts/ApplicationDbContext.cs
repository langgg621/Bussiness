using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product1529465De1> Products { get; set; }
        public DbSet<Business1529465De1> Businesses { get; set; }
        public DbSet<Relationship1529465De1> Relationships { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Relationship1529465De1>()
                .HasOne<Product1529465De1>()
                .WithMany()
                .HasForeignKey(e => e.ProductId);

            modelBuilder.Entity<Relationship1529465De1>()
                  .HasOne<Business1529465De1>()
                  .WithMany()
                  .HasForeignKey(e => e.BusinessId);

        }
    }
}
