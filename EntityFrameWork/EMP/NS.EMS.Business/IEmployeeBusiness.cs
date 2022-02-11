using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
   public interface IEmployeeBusiness
    {
        public bool AddEmployee(EmployeeModel employeeModel);
    }
}
