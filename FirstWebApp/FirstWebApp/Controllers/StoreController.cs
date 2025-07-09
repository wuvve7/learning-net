using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from Store.Index()");
        }

        public IActionResult Details(int id)
        {
            string message = "Hello from Store.Details, ID: " + id;
            return Content(message);
        }
    }
}
