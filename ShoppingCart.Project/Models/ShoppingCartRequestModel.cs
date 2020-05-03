using System;
namespace ShoppingCart.Project.Models
{
    public class ShoppingCartRequestModel
    {
        public int CartId { get; set; }
        public string SessionId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
    }

}
