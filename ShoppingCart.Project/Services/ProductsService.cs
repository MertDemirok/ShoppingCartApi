using System;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class ProductsService : IProductsService
    {
        public ProductModel GetProductById(int id)
        {
            return new ProductModel();
        }
        public ProductModel GetAllProduct()
        {
            return new ProductModel();
        }

        public void UpdateProduct(ProductModel product)
        {
            
        }

    }
}
