using BTECanada.Models;
using Microsoft.EntityFrameworkCore;

namespace BTECanada.Data
{
    public class AppDataContext : DbContext
    {
        public virtual DbSet<BuilderResources> BuilderResources { get; set; }
        public virtual DbSet<BuilderResourcesCategory> BuilderResourcesCategory { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
