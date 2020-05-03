using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Datas
{
    public partial class CustomerDataModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid SessionId { get; set; }
        public List<Order> Order { get; set; }
    }

    public partial class Order
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
