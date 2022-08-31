using BTECanada.Models;

namespace BTECanada.Services.Interfaces
{
    public interface IAppDataRepository
    {

        Task<IList<BuilderResourcesCategory>?> GetBuilderResourcesCategories();

    }
}
