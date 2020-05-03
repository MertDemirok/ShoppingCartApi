using System;
using System.Collections.Generic;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IProductsService
    {
        ProductModel GetProductById(int id);
        List<ProductModel> GetAllProduct();
        void UpdateProduct(ProductModel product);
        void Addroduct(ProductModel product);
    }
}
