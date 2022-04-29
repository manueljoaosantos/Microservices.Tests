using System.Reflection;
using Core.Entities.AdventureWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.AdventureWorks
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options){ }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }        
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderAddress> OrderAddress { get; set; }
        public DbSet<OrderLineItem> OrderLineItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductModel> ProductModel { get; set; }
        public DbSet<SalesAgent> SalesAgent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));
                    var dateTimeProperties = entityType.ClrType.GetProperties()
                        .Where(p => p.PropertyType == typeof(DateTimeOffset));

                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
                    }

                    foreach (var property in dateTimeProperties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name)
                            .HasConversion(new DateTimeOffsetToBinaryConverter());
                    }
                }
            }



modelBuilder.Entity<Order>()
.HasOne(x => x.ShipToAddress);

modelBuilder.Entity<Order>()
.HasOne(x => x.Customer);

modelBuilder.Entity<Order>()
.HasMany(x => x.OrderLineItems);

modelBuilder.Entity<OrderAddress>()
.HasMany(x => x.BillToOrders);

modelBuilder.Entity<OrderAddress>()
.HasMany(x => x.ShipToOrders);
        }
    }
}