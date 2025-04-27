using Microsoft.AspNetCore.Mvc;

namespace FirstProjectMVC.control
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }
    }
}
