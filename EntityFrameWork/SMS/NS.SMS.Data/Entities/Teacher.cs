using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NS.SMS.Data.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }
    }
}
