using System;
using System.Collections.Generic;
using System.Linq;
public class Student
{
public int StudentId { get; set; }
public string? StudentName { get; set; }
public string? Email { get; set; }
public string? Branch { get; set; }
public int Age { get; set; }

}

public class StudentResult
{
    public string StudentName{get;set;}
    public string Branch{get;set;}
    public int Age{get;set;}
}
public class StudentDetails
{
    public IList<Student> GetAllStudents(){
        return new List<Student>(){
        new Student(){StudentId=1,StudentName="Ajay",Email="choudharyajay418@gmail.com",Branch="dotnet",Age=25},
        new Student(){StudentId=2,StudentName="Abhishek",Email="abhishek@gmail.com",Branch="Python",Age=24},
        new Student(){StudentId=3,StudentName="Akshay",Email="ak321@gmail.com",Branch="PHP",Age=23},
        new Student(){StudentId=4,StudentName="Akshit",Email="akshit@gmail.com",Branch="dotnet",Age=24},
        new Student(){StudentId=5,StudentName="Kuldeep",Email="kul418@gmail.com",Branch="Python",Age=26},
        new Student(){StudentId=6,StudentName="Sahil",Email="chsahil@gmail.com",Branch="Java",Age=24},
        new Student(){StudentId=7,StudentName="Munish",Email="munihs@gmail.com",Branch="Python",Age=23},
        new Student(){StudentId=8,StudentName="PArdeep",Email="pardeep8@gmail.com",Branch="Java",Age=27},

    };
}

public void DisplayLinqQueries()
{
    var stu = from student in GetAllStudents()
              orderby student.Age 
                            select new StudentResult{
                                Age = student.Age,
                                StudentName = student.StudentName,
                                Branch=student.Branch
                            };


 foreach(var item in stu)
        {
            Console.WriteLine("{0},{1},{2}",item.StudentName,item.Age,item.Branch);
        }

}
}



