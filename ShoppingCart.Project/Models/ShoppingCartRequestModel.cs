using System;
namespace ShoppingCart.Project.Models
{
    public class ShoppingCartRequestModel
    {
        public int CartId { get; set; }
        public Guid CustomerId { get; set; }
        public int SessionId { get; set; }
        public int SessionTime { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
    }

}
