using Microsoft.AspNetCore.Mvc;

namespace ClaimsApp.Controllers
{
    public class ListOfClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
