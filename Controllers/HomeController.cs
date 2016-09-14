using Microsoft.AspNetCore.Mvc;

namespace ResponseConvetter.Controllers
{
     public class HomeController:Controller
     {
         public IActionResult Index()
         {
             
             return View();
         } 
     }
}