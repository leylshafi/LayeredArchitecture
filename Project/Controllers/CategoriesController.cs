using DomainModelEntity;
using InfrastructurePersistence;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class CategoriesController : Controller
    {
        private AppDbContext context;

        public CategoriesController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            Category category = context.Categories.Find(id);
            return View(category);

        }
    }
}
