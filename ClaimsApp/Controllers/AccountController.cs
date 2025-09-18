using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
