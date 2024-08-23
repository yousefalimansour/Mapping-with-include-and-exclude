using EF009.BasicSetup.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF009.BasicSetup.Data
{
    public class AppDbContext : DbContext
    {
         public DbSet<Order> orders {  get; set; }    
         public DbSet<OrderDetail> orderDetails { get; set; }
         public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
                .ToTable("Orders")
                .HasKey(x => x.Id);

            modelBuilder.Entity<OrderDetail>()
                .ToTable("OrderDetails")
                .HasKey(x => new { x.OrderId, x.ProductId });

            modelBuilder.Entity<Product>()
                .ToTable("Products", schema: "Inventory")
                .HasKey(x => x.Id);

            modelBuilder.HasDefaultSchema("Sales");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            var constr = configuration.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);
        }
    }
}
