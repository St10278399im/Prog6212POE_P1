using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class ClaimsHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
