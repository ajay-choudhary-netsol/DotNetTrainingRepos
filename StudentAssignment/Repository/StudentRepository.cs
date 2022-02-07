using StudentAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAssignment.Repository
{
    public class StudentRepository
    {
        public List<StudentModel> Students { get; set; }

        public StudentRepository()
        {
            Students = new List<StudentModel>();
        }

        // public List<Student> Students { get; set; }
        //public List<StudentModel> GetAllStudents()
        //{
        //    return DataSource();
        //}

        //public List<StudentModel> Editstudent()
        //{
           
        //}
        //public StudentModel GetStudentById(int id)
        //{
        //    return DataSource().Where(x => x.StudentId == id).FirstOrDefault();
        //}

        //public List<StudentModel> DataSource()
        //{
        //    return new List<StudentModel>()
        //    {
        //        new StudentModel() { StudentId = 101, StudentName = "Ajay", Email="choudharyajay48@gmail.com",Branch = "CSE", Address="Gurdaspur" },
        //        new StudentModel() { StudentId = 102, StudentName = "Abhishek",Email="attriabhi7890@gmail.com", Branch = "ETC", Address="Pathankot" },
        //        new StudentModel() { StudentId = 103, StudentName = "Munish",Email="Munish9@gmail.com", Branch = "CSE", Address="Pathankot"},
        //        new StudentModel() { StudentId = 104, StudentName = "Sahil",Email="sahil48@gmail.com", Branch = "CSE",Address="Dinanagar"},
        //        new StudentModel() { StudentId = 105, StudentName = "Jagdeep",Email="jagdeep4@gmail.com", Branch = "ETC", Address="Pathankot"}
        //    };
        //}

    }
}
