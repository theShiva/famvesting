using System.Data.Entity;

namespace SingleFamProperties.Models
{
    public class SingleFamPropertiesContext : DbContext
    {

        public SingleFamPropertiesContext() : base("SingleFamPropertiesContext")
        {
        }

        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // TODO add code-first overrides here.            
        }
    }
}