using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NS.OCS.Business;
using NS.OCS.Data.Entities;
using NS.OCS.Model;
using NS.OCS.WEB.Services;

namespace NS.OCS.WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductBusiness _iProductBusiness;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductBusiness iProductBusiness, IWebHostEnvironment webHostEnvironment)
        {
            _iProductBusiness = iProductBusiness;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult ShowAllProducts()
        {
            return View(_iProductBusiness.ShowAllProducts());
        }

        [HttpPost]
        public IActionResult Create(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                if (productModel.ImageFile != null)
                {
                    string folder = "Images";
                    folder += Guid.NewGuid().ToString() + "-" + productModel.ImageFile.FileName;       
                    productModel.Image = "/" + folder;
                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);        
                    productModel.ImageFile.CopyTo(new FileStream(serverFolder, FileMode.Create));
                }    
                _iProductBusiness.AddProduct(productModel);
                return RedirectToAction(nameof(Create), new { isSuccess = true });

            }
            return View();
        }

        [HttpGet]
        public IActionResult Create(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        [HttpGet]
        public IActionResult EditProduct(long id)
        {
            //long pId = Convert.ToInt32(EncryptingCommon.DecryptString(id.ToString()));
           return View(_iProductBusiness.GetProductById(id));
        }

        [HttpPost]
        public IActionResult EditProduct(ProductModel product)
        {
            //  long pId = Convert.ToInt32(EncryptingCommon.DecryptString(id.ToString()));


              var wwwrootpath = _webHostEnvironment.WebRootPath;
           
            _iProductBusiness.EditProduct(product, wwwrootpath);
         //   TempData["SuccessMessage"] = product.ProductName + "Updated Successfully";
            return RedirectToAction("ShowAllProducts", "Product");

        }

        public IActionResult DeleteProduct(ProductModel productModel, long id)
        {
           // long pId = Convert.ToInt32(EncryptingCommon.DecryptString(id.ToString()));
            _iProductBusiness.DeleteProduct(productModel, id);

            return RedirectToAction("ShowAllProducts", "Product");
        }
        public IActionResult GetProductById(long id)
        {
            var r = _iProductBusiness.GetProductById(id);
            return View(r);
        }

        public IActionResult ShowProductDetails(ProductDetails product,long id)
        {
            var r = _iProductBusiness.GetProductById(id);
            return View(_iProductBusiness.ShowProductDetails(product, id));

        }

    }
}
