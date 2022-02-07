using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstCoreMVCWebApplication.Models;

namespace FirstCoreMVCWebApplication.Controllers
{

    public class HomeController : Controller
    {

        //public JsonResult GetStudentDetails(int Id)
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    Student studentDetails = repository.GetStudentById(Id);
        //    return Json(studentDetails);
        //}
        //public JsonResult Index()
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    List<Student> allStudentDetails = repository.GetAllStudent();
        //    return Json(allStudentDetails);
        //}
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
