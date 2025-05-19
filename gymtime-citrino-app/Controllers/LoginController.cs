using gymtime_citrino_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace gymtime_citrino_app.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            return View();
        }
    }
}
