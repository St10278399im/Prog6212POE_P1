using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class NewClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
