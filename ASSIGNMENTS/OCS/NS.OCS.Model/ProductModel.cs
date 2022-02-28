using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NS.OCS.Model
{
    public class ProductModel
    {
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required.")]
        [MinLength(2, ErrorMessage = "Product Name must be atleast 3 characters.")]
        [MaxLength(20, ErrorMessage = "Product Name must cannot be greter than 20 Characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Type of Product Required.")]
        public string ProductType { get; set; }

        [Required(ErrorMessage = "Please Select Product Make Company")]
        public Company ProductMake { get; set; }
        public enum Company { ACER = 1, LENOVO = 2, HP = 3, TOSHIBA=4 };

        [Required(ErrorMessage = "RAM Size is Required.")]
        [MinLength(3, ErrorMessage = "RAM Size must be atleast 3 characters.")]
        [MaxLength(10, ErrorMessage = "RAM Size  cannot be greter than 10 Characters")]

        public string Ram { get; set; }

        [Required(ErrorMessage = "Operating System Selection Required")]
        [MinLength(3, ErrorMessage = "Must be atleast 3 characters.")]
        [MaxLength(10, ErrorMessage = "Cannot be greter than 10 Characters")]
        public string Os { get; set; }

        [Required(ErrorMessage = "Hard Disk Size is Required.")]
        [MinLength(3, ErrorMessage = "Must be atleast 3 characters.")]
        [MaxLength(10, ErrorMessage = "Cannot be greter than 10 Characters")]

        public string Hdd { get; set; }

        [Required(ErrorMessage = "Description is Required.")]
        public string Description { get; set; }

        
        public string Image { get; set; }

       [Required(ErrorMessage = "Please choose an Image.")]
       
        [NotMapped]
        public IFormFile ImageFile { get; set; }


        [Required(ErrorMessage = "Please Enter Price")]
        [MinLength(5, ErrorMessage = "Must be atleast 5 digits.")]
        [MaxLength(8, ErrorMessage = "Cannot be greter than 8 digits")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Price must be numeric")]
        [Range(15000, 300000, ErrorMessage = "Please Enter Price between 20000 to 300000")]
        
        public decimal Price { get; set; }

    }
}
