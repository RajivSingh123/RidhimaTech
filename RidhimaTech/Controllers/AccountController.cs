using Microsoft.AspNetCore.Mvc;
using RidhimaTech.Models;

namespace RidhimaTech.Controllers
{

    public class AccountController : Controller
    {
        // Hardcoded credentials
        private const string HardcodedUsername = "admin";
        private const string HardcodedPassword = "password123";

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username == HardcodedUsername && model.Password == HardcodedPassword)
            {
                HttpContext.Session.SetString("Username", model.Username);
                return RedirectToAction("Dashboard");
            }

            model.Message = "Invalid username or password.";
            return View(model);
        }

        public IActionResult Dashboard()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                return RedirectToAction("Login");

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
