using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NS.EMS.Data.Entities
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? Deptid { get; set; }
        public string Gender { get; set; }
    }
}
