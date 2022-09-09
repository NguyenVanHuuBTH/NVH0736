using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NVH0736.Models;

namespace NVH0736.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult Index()

    {
        return View();
    }

    public IActionResult Create(Student std)
    {
        String message = std.StudentID + "-";
        message += std.StudentName + "-";
        message += std.StudentAge;
        ViewBag.TT = message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
