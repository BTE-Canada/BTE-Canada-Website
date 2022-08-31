using BTECanada.Data;
using BTECanada.Services.Interfaces;
using Markdig;
using Microsoft.AspNetCore.Mvc;

namespace BTECanada.Controllers
{
    public class ResourcesController : Controller
    {
        private readonly IAppDataRepository _repo;

        public ResourcesController(IAppDataRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Building()
        {
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseBootstrap()
                .Build();

            var categories = await _repo.GetBuilderResourcesCategories();

            if (categories == null)
                return NotFound();

            foreach (var category in categories)
                foreach (var resource in category.BuilderResources)
                    if (resource.Content != null)
                        resource.Content = Markdown.ToHtml(resource.Content, pipeline);

            return View(categories);
        }
    }
}
