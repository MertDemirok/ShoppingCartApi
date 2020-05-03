using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Datas
{
    public class CustomerDataManager : ICustomerDataManager
    {
        public static UtilitiyService _uService = new UtilitiyService();

        public CustomerDataModel GetCustomerByCustomerId(int id)
        {
            var data = _uService.ReadJsonData<List<CustomerDataModel>>("Datas/Mock/Customers.mock.json");
            return data.Where(x => x.Id == id).FirstOrDefault();
        }
       
    }
}
