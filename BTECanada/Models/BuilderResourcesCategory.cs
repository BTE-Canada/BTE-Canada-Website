using System.ComponentModel.DataAnnotations;

namespace BTECanada.Models
{
    public class BuilderResourcesCategory
    {
        public BuilderResourcesCategory()
        {
            this.BuilderResources = new List<BuilderResources>();
        }

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Desciption { get; set; }

        public virtual ICollection<BuilderResources> BuilderResources { get; set; }
    }
}
