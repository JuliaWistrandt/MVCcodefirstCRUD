using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCcodeFirstCRUID.Data;
using MVCcodeFirstCRUID.Models;
using MVCcodeFirstCRUID.Models.Domain;

namespace MVCcodeFirstCRUID.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCcfDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public EmployeesController(ILogger<HomeController> logger, MVCcfDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employeesList = await _context.Employees.ToListAsync();

            return View(employeesList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                DateOfBirgth = addEmployeeRequest.DateOfBirgth,
                Department = addEmployeeRequest.Department
            };

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Add");
        
        }


    }
}
