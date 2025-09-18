using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class AdminSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
