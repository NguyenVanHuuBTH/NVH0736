using Microsoft.AspNetCore.Mvc;
using NVH0736.Models;
namespace NVH0736.Controllers
{
    public class StringProcessController:Controller
    
     {
     StringProcess strPro =new StringProcess();
      
      public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index(string strInput )
      {
        string StringProcess= strPro.RemoveRemainingWhiteSpace(strInput);
        ViewBag.d= StringProcess;
    
        return View();
      }
      StringProcess strPr =new StringProcess();
       public IActionResult ce()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult ce(string strInput )
      {
        string StringProcess= strPr.UpperToLower(strInput);
        ViewBag.c= StringProcess;
    
        return View();
      }
      
        StringProcess strP =new StringProcess();
       public IActionResult meme()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult meme(string strInput )
      {
        string StringProcess= strP.CapitalizeOneFirstCharacter(strInput);
        ViewBag.m= StringProcess;
    
        return View();
     }
      StringProcess str =new StringProcess();
       public IActionResult mem()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult mem(string strInput )
      {
        string StringProcess= str.RemoveVietnameseAccents(strInput);
        ViewBag.k= StringProcess;
    
        return View();
     }
     StringProcess st =new StringProcess();
       public IActionResult memi()
      {
            return View();
      }
    
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult memi(string strInput )
      {
        string StringProcess= strPro.CapitalizeFirstCharacter(strInput);
        ViewBag.p= StringProcess;
    
        return View();
      }
      }
      }