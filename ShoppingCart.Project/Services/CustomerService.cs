using System;
using System.Linq;
using ShoppingCart.Project.Datas;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ISessionDataManager _sessionDataManager = new SessionDataManager();
        public static UtilitiyService _uService = new UtilitiyService();
        private readonly ICustomerDataManager _customerDataManager = new CustomerDataManager();

        public CustomerService()
        {
        }

        public CustomerModel GetCustomer(string sessionId)
        {
            var response = _sessionDataManager.GetSessionById(sessionId);
            var customerId = "";
            if (response.CustomerHashId != null)
            {
                customerId = _uService.Decrypt(response.CustomerHashId.ToString(), true);
            }
            else
            {
                //TODO: ERROR Handle
            }
           
            var currentCustomer = _customerDataManager.GetCustomerByCustomerId(Convert.ToInt32(customerId));

            CustomerModel customer = new CustomerModel();

            customer.Orders = currentCustomer.Order.Select(x => new OrderModel()
            {
                Id = x.Id,
                ProductId = x.ProductId,
                IsActive = x.IsActive,
                Name = x.Name,
                OrderCreateDate = x.OrderCreateDate,
                Quantity = x.Quantity,
                CategoryId = x.CategoryId
            }).ToList();


            return customer;
        }

    }
}
