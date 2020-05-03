using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public List<SubCategoryModel> SubCategory { get; set; }
    }
}
