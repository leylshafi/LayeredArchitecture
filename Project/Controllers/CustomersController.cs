using DomainModelEntity;
using InfrastructurePersistence;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class CustomersController : Controller
    {
        private AppDbContext context;

        public CustomersController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Customers.ToList());
        }

        public IActionResult Details(int id)
        {
            Customer customer = context.Customers.Find(id);
            return View(customer);
        }
    }
}
