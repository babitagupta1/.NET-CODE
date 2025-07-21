using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using stornglytypedView.Models;

namespace stornglytypedView.Controllers
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
            //yo code single bind garnalai use vaya xa
            //Employee Obj = new Employee()
            //{
            //    Id = 1,
            //    Name = "babita",
            //    Salary = 999889,
            //};
            //return View( Obj);

            //now use to list bind
            var employee = new List<Employee>
            {
                new Employee{ Id=1,Name="knk",Salary=899},
                new Employee{ Id=2,Name="nmdmdmd",Salary=2567},
                new Employee{ Id=3,Name="knk",Salary=35000},


            };
            return View(employee);
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
