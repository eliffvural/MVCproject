using Microsoft.AspNetCore.Mvc;

namespace MVCproject.Controllers
{
    public class FirstController : Controller
    {

        //sayhello adinda bir action oluşturalim:
        public IActionResult SayHello()
        {
            return View("HelloView");
        }
    }
}
