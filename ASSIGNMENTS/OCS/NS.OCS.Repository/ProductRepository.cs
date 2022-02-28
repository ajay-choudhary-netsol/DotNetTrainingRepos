using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.OCS.Data.Entities;
using NS.OCS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace NS.OCS.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductDetails> ShowAllProducts()
        {
            List<ProductDetails> returnList = new List<ProductDetails>();
            using (var context = new ProductDBContext())
            {
                returnList = context.ProductDetails.ToList();
            }

            return returnList;
        }
        public bool AddProduct(ProductModel productModel)
        {
            using (var context = new ProductDBContext())
            {
                ProductDetails product = new ProductDetails();
                product.ProductName = productModel.ProductName;
                product.ProductType = productModel.ProductType;
                product.ProductMake = (ProductDetails.Company)productModel.ProductMake;
                product.Ram = productModel.Ram;
                product.Os = productModel.Os;
                product.Hdd = productModel.Hdd;
                product.Description = productModel.Description;
                product.Image = productModel.Image;
                product.Price = productModel.Price;
                context.ProductDetails.Add(product);
                context.SaveChanges();

            }
            return true;
        }

        public ProductDetails GetProductById(long id)
        {
            ProductDBContext context = new ProductDBContext();
            var productid = context.ProductDetails.Where(x => x.ProductId == id).FirstOrDefault();

            return productid;
        }

        public bool EditProduct(ProductModel product, string wwwrootpath)
        {
            if (product.ImageFile != null)
            {
                string imageFileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string imageFileExtension = Path.GetExtension(product.ImageFile.FileName);
                string imageName = imageFileName + imageFileExtension;
                string imagePath = Path.Combine(wwwrootpath + "/Images/", imageName);
                string imagePath1 = Path.Combine("/Images/", imageName);

                // product.ImageFile.CopyTo(new FileStream(imagePath, FileMode.Create));
                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                {
                    product.ImageFile.CopyTo(fileStream);
                }

                using (var context = new ProductDBContext())
                {
                    var paraamList = new List<SqlParameter>();
                    paraamList.Add(new SqlParameter("@ProductId", product.ProductId));
                    paraamList.Add(new SqlParameter("@ProductName", product.ProductName));
                    paraamList.Add(new SqlParameter("@ProductType", product.ProductType));
                    paraamList.Add(new SqlParameter("@ProductMake", product.ProductMake));
                    paraamList.Add(new SqlParameter("@Ram", product.Ram));
                    paraamList.Add(new SqlParameter("@Os", product.Os));
                    paraamList.Add(new SqlParameter("@Hdd", product.Hdd));
                    paraamList.Add(new SqlParameter("@Description", product.Description));
                    paraamList.Add(new SqlParameter("@Image", imagePath1));
                    paraamList.Add(new SqlParameter("@Price", product.Price));

                    context.Database.ExecuteSqlRaw("uspEditProduct @ProductId, @ProductName, @ProductType, @ProductMake, @Ram, @Os, @Hdd, @Description, @Image,@Price", paraamList);
                }
            }
            else
            {
                using (var context = new ProductDBContext())
                {
                    var paraamList = new List<SqlParameter>();
                    paraamList.Add(new SqlParameter("@ProductId", product.ProductId));
                    paraamList.Add(new SqlParameter("@ProductName", product.ProductName));
                    paraamList.Add(new SqlParameter("@ProductType", product.ProductType));
                    paraamList.Add(new SqlParameter("@ProductMake", product.ProductMake));
                    paraamList.Add(new SqlParameter("@Ram", product.Ram));
                    paraamList.Add(new SqlParameter("@Os", product.Os));
                    paraamList.Add(new SqlParameter("@Hdd", product.Hdd));
                    paraamList.Add(new SqlParameter("@Description", product.Description));
                    paraamList.Add(new SqlParameter("@Price", product.Price));

                    context.Database.ExecuteSqlRaw("uspEditProductWithoutImage @ProductId, @ProductName, @ProductType, @ProductMake, @Ram, @Os, @Hdd, @Description,@Price", paraamList);

                } 
            }
            return true;
        }

        public bool DeleteProduct(ProductModel productModel, long id)
        {

            using (var context = new ProductDBContext())
            {
                ProductDetails product = new ProductDetails();
                product.ProductId = id;
                product.ProductName = productModel.ProductName;
                product.ProductType = productModel.ProductType;
                product.ProductMake = (ProductDetails.Company)productModel.ProductMake;
                product.Ram = productModel.Ram;
                product.Os = productModel.Os;
                product.Hdd = productModel.Hdd;
                product.Description = productModel.Description;
                product.Image = productModel.Image;
                product.Price = productModel.Price;
                context.Remove(product);
                context.SaveChanges();
            }
            return true;
        }


        public List<ProductDetails> ShowProductDetails(ProductDetails product, long id)
        {
            ProductDBContext context = new ProductDBContext();
            var productid = from s in context.ProductDetails
                            where s.ProductId == id
                            select s;

            return productid.ToList();
        }


    }
    }
