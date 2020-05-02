using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IProductsService
    {
        ProductModel GetProductById(int id);
        ProductModel GetAllProduct();
        void UpdateProduct(ProductModel product);
    }
}
