using System;
namespace ShoppingCart.Project.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public string OrderCreateDate { get; set; }
    }
}
