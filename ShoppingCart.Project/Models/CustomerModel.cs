using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public int UserrName { get; set; }
        public int CartId { get; set; }
        public List<OrderModel> Orders { get; set; }
        public int SessionId { get; set; }
        public DateTime SessionTime { get; set; }

    }
}
