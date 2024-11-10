using Microsoft.AspNetCore.Mvc;

namespace MVCproject.Controllers
{
    public class PastDataController : Controller
    {

        //index adinda bir action oluşturalim:
        public IActionResult Index()
        {
            ViewData["name"]= "Emre Elif";
            ViewBag.age=22;

            List<string>colors= new List<string>{"black", "white"};
            ViewData["colors"] = colors;

            return View();


        }
    }
}
