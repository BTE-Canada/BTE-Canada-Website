using BTECanada.Data;
using Microsoft.AspNetCore.Mvc;

namespace BTECanada.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Building()
        {
            return View(SampleData.categories);
        }
    }
}
