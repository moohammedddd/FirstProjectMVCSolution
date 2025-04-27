using FirstProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProjectMVC.control
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Return View with the same Name as the action Name 
                           // return View(new Movie()); //Return view with the same name as the action name and bind the model data to view 
                           //return View ("Mohamed"); // Return views with the Provided Name
                           //  return View("Mohamed", new Movie()); 


        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

    }
}
