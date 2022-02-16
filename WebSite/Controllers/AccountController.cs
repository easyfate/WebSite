using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
