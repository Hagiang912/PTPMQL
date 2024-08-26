using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers
{
    public class HagiangController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
