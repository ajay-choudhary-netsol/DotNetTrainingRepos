using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreMVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FirstCoreMVCWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
       

        public IActionResult Index()
        {
         
          
            return View();
        }

      

        [HttpPost]
        public IActionResult Registration(Registration registration)
        {
            if (ModelState.IsValid)
            {
                if (registration.Email == "abc@gmail.com")
                {
                    ModelState.AddModelError("Email", "Email cannot be 'abc@gmail.com'");
                }
                if (ModelState.ErrorCount == 0)
                {
                    Debug.WriteLine("Valid");
                    TempData["SuccessMessage"] = "Account Created Successfully";
                }
            }
            return View("Index");
        }


    }
}
