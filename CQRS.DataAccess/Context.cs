using System.Data.Entity;
using CQRS.DataAccess.Entities;
using CQRS.Contracts;
using CQRS.Contracts.AddProductQuantity;
using CQRS.Contracts.AddProduct;

namespace CQRS.DataAccess
{
    public class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public Context() :base("CQRS_Write_Context")
        {                      
        }

        public DbSet<EventBase> Events { get; set; }

        public DbSet<ProductAddedEvent> ProductAddedEvent { get; set; }

        public DbSet<ProductQuantityAddedEvent> ProductQuantityAddedEvents { get; set; }

        public DbSet<ProductNameChangedEvent> ProductNameChangedEvents { get; set; }

        public DbSet<ProductPriceChangedEvent> ProductPriceChangedEvents { get; set; }
    }
}
