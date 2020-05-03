using System;
using System.Collections.Generic;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Datas
{
    public interface IProductDataManager
    {
        List<Product> GetAll();
        Product GetProductById(int id);
    }
}
