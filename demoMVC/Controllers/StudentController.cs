namespace demoMVC.Controllers;
public class StudentController : Controller
{
        public IActionResult Index()
    {
        return View(); 
    }
    [HttpPost]
     public IActionResult Index(StudentController st)
    {
        string strResult = "Hello" + Fullname + "-" + Address;
        ViewBag.thongBao  = strResult;
        return View();
    }
}