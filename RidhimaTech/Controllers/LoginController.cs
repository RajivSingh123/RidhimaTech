using Microsoft.AspNetCore.Mvc;

namespace RidhimaTech.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
