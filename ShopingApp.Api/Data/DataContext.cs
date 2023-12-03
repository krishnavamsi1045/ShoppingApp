using Microsoft.EntityFrameworkCore;
using ShopingApp.Api.Data.Entities;

namespace ShopingApp.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
       
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Usercs> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(ref modelBuilder);
        }
        private static void SeedData(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasData(Role.GetInitialRoles());

            modelBuilder.Entity<Usercs>()
                .HasData(Usercs.GetInitialUsers());

        }
    }
}
