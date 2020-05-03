using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerModel GetCustomer(string id);
    }
}
