using Microsoft.AspNetCore.Mvc;

namespace gymtime_citrino_app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password, bool RememberMe)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                ModelState.AddModelError("", "E-mail ou senha inválidos.");
                return View();
            }

            if (Email == "admin" && Password == "password")
            {
                if (RememberMe)
                {
                }
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "E-mail ou senha inválidos.");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(); 
        }
    }
}
