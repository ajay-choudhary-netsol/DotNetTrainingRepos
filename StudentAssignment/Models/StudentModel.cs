using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAssignment.Models
{


    public class StudentModel
    {
        [Display(Name = "StudentId")]
        
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Email Id")]
        public string Email { get; set; }


        [Display (Name = "Branch")]
        public string Branch { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


    }
}




