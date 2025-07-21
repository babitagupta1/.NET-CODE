using ASPCora__viewimport.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCora__viewimport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> student  = new List<Student>
            {
                new Student{ Id=1,Name="knk",Age=899},
                new Student{ Id=2,Name="nmdmdmd" ,Age=2567},
                new Student{ Id=3,Name="knk",Age=35000},


            };
            return View(student);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contect()
        {
            return View();
        }
    }
}
