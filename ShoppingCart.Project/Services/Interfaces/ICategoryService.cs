using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface ICategoryService
    {
        CategoryModel GetCategoryByProductId(int id);
        void AddCategory(CategoryModel category);
    }
}
