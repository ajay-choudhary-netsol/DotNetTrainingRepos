using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentAssignment.Models;
using StudentAssignment.Repository;

namespace StudentAssignment.Controllers
{
    public class StudentController : Controller
    {

        static List<StudentModel> _studentRepository=new List<StudentModel>()
        {

            new StudentModel() { StudentId = 101, StudentName = "Ajay", Email = "choudharyajay48@gmail.com", Branch = "CSE", Address = "Gurdaspur" },
                new StudentModel() { StudentId = 102, StudentName = "Abhishek", Email = "attriabhi7890@gmail.com", Branch = "ETC", Address = "Pathankot" },
                new StudentModel() { StudentId = 103, StudentName = "Munish", Email = "Munish9@gmail.com", Branch = "CSE", Address = "Pathankot" },
                new StudentModel() { StudentId = 104, StudentName = "Sahil", Email = "sahil48@gmail.com", Branch = "CSE", Address = "Dinanagar" },
                new StudentModel() { StudentId = 105, StudentName = "Jagdeep", Email = "jagdeep4@gmail.com", Branch = "ETC", Address = "Pathankot" }
            };


        public IActionResult GetAllStudents()
        {
            var data = _studentRepository.OrderBy(s => s.StudentId).ToList();

            return View(data);
        }


        public ActionResult AddStudent()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(IFormCollection collection)
        {
            StudentModel formData = new StudentModel() { StudentId = Int32.Parse(collection["StudentId"]), StudentName = collection["StudentName"], Email = collection["Email"], Branch = collection["Branch"], Address = collection["Address"], };
            _studentRepository.Add(formData);
            return View("GetAllStudents", _studentRepository);
            
        }




        public IActionResult EditStudent(int id)
        {
            return View(_studentRepository.Where(stu => stu.StudentId == id).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStudent(StudentModel stu)
        {
            var student = _studentRepository.Where(student => student.StudentId == stu.StudentId).FirstOrDefault();
            _studentRepository.Remove(student);
            _studentRepository.Add(stu);
            return RedirectToAction("GetAllStudents");
        }

        public ActionResult Delete(int id)
        {
            var itemToRemove = _studentRepository.Find(r => r.StudentId==id);
            _studentRepository.Remove(itemToRemove);
            return View("GetAllStudents", _studentRepository);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetAllStudents));
            }
            catch
            {
                return View();
            }
        }


        //public IActionResult Index(int id)
        //{

        //}
    }
}
