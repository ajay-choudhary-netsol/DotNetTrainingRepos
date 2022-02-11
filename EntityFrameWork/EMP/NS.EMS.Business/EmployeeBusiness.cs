using NS.EMS.Model;
using NS.EMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public class EmployeeBusiness:IEmployeeBusiness
    {
        private readonly IEmployeeRepo _IEmployeeRepo;
        public EmployeeBusiness(IEmployeeRepo IEmployeeRepo)
        {
            _IEmployeeRepo = IEmployeeRepo;
        }
        public bool AddEmployee(EmployeeModel employeeModel)
        {
           return _IEmployeeRepo.AddEmployee(employeeModel);
        }
    }
}
