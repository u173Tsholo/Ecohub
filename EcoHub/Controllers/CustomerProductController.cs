using Microsoft.AspNetCore.Mvc;

namespace EcoHub.Controllers
{
    public class CustomerProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
