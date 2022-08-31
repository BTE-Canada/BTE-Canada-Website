using BTECanada.Models;
using MySql.Data.EntityFramework;
using System.Data.Common;
using System.Data.Entity;

namespace BTECanada.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppDataContext : DbContext
    {
        public DbSet<BuilderResources> BuilderResources { get; set; }
        public DbSet<BuilderResourcesCategory> BuilderResourcesCategory { get; set; }

        public AppDataContext() : base()
        {

        }

        public AppDataContext(DbConnection existingConection, bool contextOwnsConection) : base(existingConection, contextOwnsConection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
