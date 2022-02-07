using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCWebApplication.Models
{
    public class TestStudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { StudentId = 101, StudentName = "Ajay", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 102, StudentName = "Abhishek", Branch = "ETC", Section = "B", Gender = "Male" },
                new Student() { StudentId = 103, StudentName = "Munish", Branch = "CSE", Section = "A", Gender = "Male" },
                new Student() { StudentId = 104, StudentName = "Sahil", Branch = "CSE", Section = "A", Gender = "Female" },
                new Student() { StudentId = 105, StudentName = "Jagdeep", Branch = "ETC", Section = "B", Gender = "Female" }
            };
        }

      

        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == StudentId);
        }
        public List<Student> GetAllStudent()
        {
            return DataSource();
        }
    }
}
