using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVCAppLINQ.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName{ get; set; }
        public string Emailid { get; set; }
        public string Department{ get; set; }

        public string Salary { get; set; }


    }
}
