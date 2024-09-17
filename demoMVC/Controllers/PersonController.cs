using Microsoft.AspNetCore.Mvc;
using demoMVC.Controllers;
using demoMVC.Models;
namespace demoMVC.Controllers
{
    public class PersonController: Controller
{
        public IActionResult Index()
    {
        return View(); 
    }

    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strOutput = "Xin chao " + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.infoPerson  = strOutput;
        return View();
    }
}
}


