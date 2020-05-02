using System;
namespace ShoppingCart.Project.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public CategoryModel Category { get; set; }
    }
}
