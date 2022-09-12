using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NVH0736.Models;

namespace NVH0736.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Employee> stdList = new List<Employee>()
        {
            new Employee {EmployeeID = 1, EmployeeName = "Nguyen Van A", EmployeeAge = 18},
            new Employee {EmployeeID = 2, EmployeeName = "Nguyen Van B", EmployeeAge = 19},
            new Employee {EmployeeID = 3, EmployeeName = "Nguyen Van C", EmployeeAge = 25},
            new Employee {EmployeeID = 4, EmployeeName = "Nguyen Van D", EmployeeAge = 20},
            new Employee {EmployeeID = 5, EmployeeName = "Nguyen Van E", EmployeeAge = 26},
        };
        ViewData["Employees"] = stdList;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee std)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
