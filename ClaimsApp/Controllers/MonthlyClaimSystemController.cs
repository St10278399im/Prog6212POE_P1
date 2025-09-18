using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class MonthlyClaimSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
