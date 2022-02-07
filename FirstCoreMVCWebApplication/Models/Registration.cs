using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreMVCWebApplication.Models
{
    public class Registration
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage="First Name is Required.")]
        [MinLength(3,ErrorMessage ="First Name must be atleast 3 characters.")]
        [MaxLength(15,ErrorMessage ="First Name must cannot be greter than 15 Characters")]
        public string FirstName{ get; set;}

        [DisplayName("Last Name")]
        [Required(ErrorMessage ="Last Name Required")]
        [MinLength(2,ErrorMessage ="Last Name must be atleast 2 characters.")]
        [MaxLength(20,ErrorMessage ="Last name cannot be more than 20 Characters")]
        public string LastName{get; set;}


       // public int UserId{get; set; }
       [DisplayName("Password")]

       [Required(ErrorMessage ="Password is Required")]
       //[MinLength(8,ErrorMessage ="Password must be atleast of length 8")]
        public string Password {get; set;}

        [DisplayName("Email")]
        [Required(ErrorMessage ="Email Required.")]
        [EmailAddress]
        public string Email{ get; set; }
        [DisplayName("Contact")]
        [Required(ErrorMessage ="Contact Nummber Required.")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", 
        // ErrorMessage = "Please enter PhoneNumber as 0123456789, 012-345-6789, (012)-345-6789.")]
        public string Contact{  get; set; }
    }
}
