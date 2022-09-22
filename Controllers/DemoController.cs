using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using NVH0736.Models.Process;
using NVH0736.Models;

namespace NVH0736.Controllers;

public class DemoController : Controller
{
     private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();

    public GiaiPhuongTrinh Gpt { get => gpt; set => gpt = value; }

    public IActionResult Index()
    {
 
    // // khai bao bien
    // // kieu_du_lieu ten_Bien = Gia_Tri;
    // int hesoA = 5;
    // int hesoB;
    // double x;
    // string str = "xin chao";
    // //if else; swith case; do while; while; for;
    // // if(hesoA == 0)
    // // { 
    // //     ViewBag.thongBao = " he so A = 0";
    // // }

    // for(int i = 0; i< hesoA; i++)
    // {
        
    // }
    //     //Khai bao 2 bien kieu string
    //     string soNguyen = "5";
    //     //khai bao 1 bien kieu int
    //     int so;
    //     //so = soNguyen; => can chuyen doi kieu du lieu
    //     so = Convert.ToInt32(soNguyen);
    //     so = int.Parse(soNguyen);
        return View();
    }
    // nhan duoc du lieu tu view gui len
    [HttpPost]
    
    public IActionResult Index( Double c, Double hesoA, Double hesoB, Double a, Double b)
    { 
        //tinh nghiem của phuong trinh
        //1. khai bao bien
        
        string mess = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
        string note = gpt.GiaiPhuongTrinhBacHai(a, b, c);

        ViewBag.thongBao = mess;
        ViewBag.ketqua = note;
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