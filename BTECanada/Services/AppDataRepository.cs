using BTECanada.Data;
using BTECanada.Models;
using BTECanada.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace BTECanada.Services
{
    public class AppDataRepository : IAppDataRepository
    {

        private readonly AppDataContext _dbContext;

        public AppDataRepository(AppDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<BuilderResourcesCategory>?> GetBuilderResourcesCategories()
        {
            try
            {
                await _dbContext.SaveChangesAsync();

                var resources = _dbContext.BuilderResourcesCategory.Include(x => x.BuilderResources).ToList();

                return resources;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
