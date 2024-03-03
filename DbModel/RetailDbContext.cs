using KodtestMio.DbModel.EntityConfigurations;
using KodtestMio.DbModel.EntityModels;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace KodtestMio.DbModel
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());

            if (Environment.GetEnvironmentVariable("IsRunningFromTests") != "true")
            {
                var path = "DbModel/SeedData/products.json";
                var jsonData = File.ReadAllText(path);
                var products = JsonSerializer.Deserialize<List<Product>>(jsonData);

                for (int i = 0; i < products.Count; i++)
                {
                    products[i].Id = i + 1;
                }

                if (products != null)
                {
                    modelBuilder.Entity<Product>().HasData(products);
                }
            }
        }
    }
}
