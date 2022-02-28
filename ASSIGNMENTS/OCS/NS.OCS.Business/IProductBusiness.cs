using NS.OCS.Data.Entities;
using NS.OCS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.OCS.Business
{
   public interface IProductBusiness
    {
        List<ProductDetails> ShowAllProducts();

        bool AddProduct(ProductModel productModel);

        ProductDetails GetProductById(long id);
        bool EditProduct(ProductModel product,string wwwrootpath);

          bool DeleteProduct(ProductModel productModel, long id);

        List<ProductDetails> ShowProductDetails(ProductDetails product, long id);

    }
}
