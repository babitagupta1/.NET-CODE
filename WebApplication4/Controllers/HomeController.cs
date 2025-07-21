using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication4.Controllers
{
    
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("/Home")]

        public IActionResult Index()

        {

            ViewData["data1"] = "hyyyy";
            ViewBag.data2 = "hello";
    
            TempData["data5"] = "Tempdata";
            //TempData.Keep("data5");


            //TempData["data5"] = new List<string>()
            //{
            //     "Apple","ball","cat"
            // };


            return View();
        }
        public IActionResult About()
        {
            //TempData.Keep("data5");
            return View();
        }

        public IActionResult Contect()
        {
            //TempData.Keep("data5");
            return View();
        }

    

       
    }
}


//ViewBag.data1 = "programater";
//ViewBag.data2 = 788888;
//ViewBag.data3 = DateTime.Now.ToShortDateString();

//string[] arr = { "Babita", "Dilip", "Roshan" };
//ViewBag.data4 = arr;

//ViewData["data1"] = "babita";
//    ViewData["data2"] = 34;
//    ViewData["data3"] = DateTime . Now.ToLongDateString();

//    string[] arr = { "aasa", "ajk", "nnmm" };
//    ViewData["data4"] = arr;

//    ViewData["data5"] = new List<string>(){
//    "Apple","ball","cat"
//     };
