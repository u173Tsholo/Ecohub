using Microsoft.AspNetCore.Mvc;

namespace EcoHub.Controllers
{
    public class SupplierProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
