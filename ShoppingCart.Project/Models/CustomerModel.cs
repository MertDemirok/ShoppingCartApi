using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid SessionId { get; set; }
        public List<OrderModel> Orders { get; set; }



    }
}

