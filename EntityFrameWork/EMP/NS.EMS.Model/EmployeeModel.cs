using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace NS.EMS.Model
{
   public class EmployeeModel
    {
        public int EID { get; set; }

        [Required(ErrorMessage = "Employee Name is Required.")]
        [MinLength(3, ErrorMessage = " Name must be atleast 3 characters.")]
        [MaxLength(20, ErrorMessage = "Name must cannot be greter than 15 Characters")]
        public string EmployeeName{ get; set; }

       
        [Required(ErrorMessage = "Email Required.")]
        [EmailAddress]
        public  string Email { get; set; }

        //[Required(ErrorMessage = "required Field")]
        //public string Department { get; set; }


        [Required(ErrorMessage = "Contact Nummber Required.")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Contact Nummber Required.")]
        public string Gender { get; set; }

        //public int Deptid { get; set; }
        
        public Deptartment Deptid { get; set; }

        public enum Deptartment { Dotnet=1, Python=2, PHP=3 };


    }
}
