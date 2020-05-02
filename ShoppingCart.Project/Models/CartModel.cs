using System;
namespace ShoppingCart.Project.Models
{
    public class CartModel
    {
        public Guid CustomerId { get; set; }
        public int SessionId { get; set; }
        public int SessionTime { get; set; }
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
