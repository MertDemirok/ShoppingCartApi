using System;
namespace ShoppingCart.Project.Models
{
    public class ShoppingCartResponseModel
    {

        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double TotalDiscount { get; set; }

    }
}
