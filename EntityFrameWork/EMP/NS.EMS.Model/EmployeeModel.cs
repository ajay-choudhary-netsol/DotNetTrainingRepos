using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace NS.EMS.Model
{
   public class EmployeeModel
    {
        public int EID{ get; set; }

        [Required (ErrorMessage ="required Field")]
        public string EmployeeName{ get; set; }

        [Required(ErrorMessage = "required Field")]
        public  string Email { get; set; }

        [Required(ErrorMessage = "required Field")]
        public string Department { get; set; }

        [Required(ErrorMessage = "required Field")]
        public string Mobile { get; set; }
    }
}
