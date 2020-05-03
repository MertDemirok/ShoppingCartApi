using System;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryModel GetCategoryByProductId(int id)
        {
            return new CategoryModel();
        }

        public void AddCategory(CategoryModel category)
        {
        }

    }
}
