using NS.EMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS.EMS.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public bool Login(Login login)
        {
            using(var context=new EmployeeDBContext())
            {
                var user = context.Login.Where(x => x.UserName==login.UserName && x.Password==login.Password &&x.IsActive==true);
            }



            return true;
        }
    }
}
