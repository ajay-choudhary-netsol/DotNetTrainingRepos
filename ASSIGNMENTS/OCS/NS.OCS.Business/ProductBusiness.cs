using NS.OCS.Data.Entities;
using NS.OCS.Model;
using NS.OCS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.OCS.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _iProductRepository;
        public ProductBusiness(IProductRepository IProductRepository)
        {
            _iProductRepository = IProductRepository;
        }
        public List<ProductDetails> ShowAllProducts()
        {
            return _iProductRepository.ShowAllProducts();
        }

       public bool AddProduct(ProductModel productModel)
        {
            return _iProductRepository.AddProduct(productModel);
        }
        public ProductDetails GetProductById(long id)
        {
            return _iProductRepository.GetProductById(id);
        }
       public bool EditProduct(ProductModel product, string wwwrootpath)
        {
            return _iProductRepository.EditProduct(product, wwwrootpath);
        }
        public bool DeleteProduct(ProductModel productModel, long id)
        {
            return _iProductRepository.DeleteProduct(productModel, id);

        }

        public List< ProductDetails> ShowProductDetails(ProductDetails product, long id)
        {

            return _iProductRepository.ShowProductDetails(product,id);
        }

    }
}
