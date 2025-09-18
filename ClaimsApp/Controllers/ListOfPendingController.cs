using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class ListOfPendingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
