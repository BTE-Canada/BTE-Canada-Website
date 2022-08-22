namespace BTECanada.Models
{
    public class BuilderResourcesCategory
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Desciption { get; set; }

        public List<BuilderResources>? BuilderResources { get; set; }
    }
}
