using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NVH0736.Models;

namespace NVH0736.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;
    

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }
   
        List<Person> PersonList = new List<Person>()
        {
          new Person {ID=1, FullName="Hoàng", Gender="Nam", Phone = 07865678, Address= "Hà Nội" },
          new Person {ID=2, FullName="Nhi", Gender="Nữ", Phone = 011225618, Address= "Đà Nẵng" },
          new Person {ID=3, FullName="Việt", Gender="Nam", Phone = 09655678, Address= "TP Hồ Chí Minh" },
          new Person {ID=4, FullName="Hoàng", Gender="Nam", Phone = 02345609, Address= "Hà Nam" },
          new Person {ID=5, FullName="Mai", Gender="Nữ", Phone = 012345678, Address= "Hải Phòng" }
        };
        
        public IActionResult Index()
    {
        ViewData["Person"]= PersonList;
        return View();
    }

    public IActionResult Search( int ID, String searchString)
    {
         var std = PersonList.Where(s => s.ID == ID).FirstOrDefault(); 
        return View(std);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}