using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NS.SMS.Data.Entities
{
  public  class Course
    {

    [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
