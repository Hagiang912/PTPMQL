using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetMVC.Data;

namespace NetMVC.Controllers
{

    

    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;

        }
        // GET:Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());

        }
        // Get:Employee/Details
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee
            .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);

         }
         // Get:Employee/Create
         

    }
}