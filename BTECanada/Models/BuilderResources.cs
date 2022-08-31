using System.ComponentModel.DataAnnotations;

namespace BTECanada.Models
{
    public class BuilderResources
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public virtual BuilderResourcesCategory? Category { get; set; }
    }
}
