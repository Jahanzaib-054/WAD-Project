using Microsoft.AspNetCore.Mvc;

namespace petStoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
