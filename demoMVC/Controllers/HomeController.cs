using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demoMVC.Models;

namespace demoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Demo()
    {
        return View(); 
    }
    [HttpPost]
     public IActionResult Demo(string hovaten, string diachi)
    {
        string strResult = "Hello" + hovaten + "-" + diachi;
        ViewBag.thongBao  = strResult;
        return View();
    } 
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
