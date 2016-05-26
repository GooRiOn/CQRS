using System.Data.Entity;
using CQRS.DataAccess.Entities;

namespace CQRS.DataAccess
{
    public class Context : DbContext
    {
        public Context() :base("CQRS_Write_Context")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        internal DbSet<EventsEntity> Events { get; set; }
    }
}
