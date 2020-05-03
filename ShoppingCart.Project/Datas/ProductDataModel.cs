using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Datas
{
    public partial class ProductDataModel
    {
        public List<Product> Products { get; set; }
    }

    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Brand Brand { get; set; }
        public GroupCategory Category { get; set; }
    }

    public partial class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class GroupCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<SubCategory> SubCategory { get; set; }
    }

    public partial class SubCategory
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

}
