using FirstProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace FirstProjectMVC.control
{
    public class MoviesController : Controller
    {

        // To Execute any action => BaseUrl + ControllerName + ActionName/?
        //public string GetMovie(int? id)
        //{
        //    if(id is not null)
        //    return $"Movie {id}";
        //    else
        //        return "Movie not found";
        //}

        public IActionResult GetMovie(int? id, string name)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = $"Hello World,,,,,,,, {id}</br>{name}";
            //contentResult.ContentType = "text/html";
            //contentResult.StatusCode = 900;

            //return contentResult;
            // can summarize it to make 
            //return Content($"Hello World,,,,,,,, {id}</br>{name}" ,"text/html");


            /*************************************************************/
            // id = 0 : bad request
            //id < 10 : Not Found
            //id >= 10 : Movie
            if (id == 0)
            {
                return BadRequest();
            }
            else if (id < 10)
            {
                return Content("Not Found", "text/html");
            }
            else
            {
                return Content($"Movie {id}", "text/html");
            }

        }


        public string Index(int? id)
        {
            if (id is not null)
                return $"Hello {id}";
            else
                return "Index is  not found";
        }

        public IActionResult TestRedirectAction(Movie movie)
        {
            return Redirect("https://chatgpt.com/c/67087b3c-477c-800d-8eb3-bb0883671c89");
        }
        public IActionResult TestRediretGetMovies() // this rout to call action like GetMovies
        {
            //return RedirectToAction("GetMovies", new {id = 30, name = "RAfat"});

            //Return Rout
            return RedirectToRoute("Rafat", new { id = 40, name = "Rafat" });
        }

        public IActionResult TestModelBinding(int id, string name)
        {
            return Content($"Hello {id} name {name}");
        }
    }
}
