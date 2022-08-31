using System.ComponentModel.DataAnnotations;

namespace BTECanada.Models
{
    public class BuilderResourcesCategory
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<BuilderResources> BuilderResources { get; set; }
    }
}
