using System;
using System.Collections.Generic;
using System.Text;
using NS.EMS.Model;

namespace NS.EMS.Repository
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(EmployeeModel employeeeModel);

    }
}
