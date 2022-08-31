using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTECanada.Models
{
    public class BuilderResources
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Content { get; set; }

        public int? CategoryId { get; set; }

        public virtual BuilderResourcesCategory Category { get; set; }
    }
}
