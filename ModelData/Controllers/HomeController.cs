using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelData.Models;

namespace ModelData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
     
            //Employee emp = new Employee()
            //{
            //    EmpId = 11,
            //    Name = "Babita",
            //    Desiganation = "nckc",
            //    salary = 199000,
            //};

            var Myemployee = new List<Employee>
            {
                new Employee {   EmpId = 1 ,Name = "Babita", Desiganation = "nckc",salary = 199000, },
                new Employee {   EmpId = 2 ,Name = "sabita", Desiganation = "kjskfj",salary = 34554, },
                new Employee {   EmpId = 3,Name = "mamta", Desiganation = "cckjsc",salary = 2333440, },
                new Employee {   EmpId = 4 ,Name = "rita", Desiganation = "nckc",salary = 893340, },

};

            ViewData["myemp"] = Myemployee;

            //ViewData["myemp"] = emp;
            //ViewBag.myemp = emp;
            //TempData["myemp"] = emp;

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
}
