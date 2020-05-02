using System;
namespace ShoppingCart.Project.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public SubCategoryModel SubCategory { get; set; }
    }
}
