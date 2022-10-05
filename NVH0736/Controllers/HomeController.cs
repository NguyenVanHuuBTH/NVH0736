using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NVH0736.Models;

namespace NVH0736.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index(String FullName, String email)
    { 
        ViewBag.name ="Hello" + " " + FullName + " " + email;
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
