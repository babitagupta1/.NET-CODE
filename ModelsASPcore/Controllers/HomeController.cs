using Humanizer;
using Microsoft.AspNetCore.Mvc;
using ModelsASPcore.Models;
using ModelsASPcore.Repository;
using System.Diagnostics;
using System.Reflection;

namespace ModelsASPcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }
        public List<StudentModel> getAllStudent()
        {
            return _studentRepository.getAllStudent();
        }


        public StudentModel getById( int id)
        {
            return _studentRepository.getStudentById(id);
        } 
            
            public IActionResult Index()
        { 
        //{
        //    var Students = new List<StudentModel>
        //    {
        //        new StudentModel { RollNum =  1, Name="Babita"  ,Gender="Female",Stander=10},
        //        new StudentModel { RollNum =  2, Name="Sita", Gender = "Female" ,Stander =11},
        //        new StudentModel { RollNum =  3, Name="Sabita", Gender = "Female", Stander=12}

        //    };
        //    ViewData["mystudent"] = Students;
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
