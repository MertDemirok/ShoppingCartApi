using System;
namespace ShoppingCart.Project.Datas
{
    public interface ICustomerDataManager
    {
        CustomerDataModel GetCustomerByCustomerId(int id);
    }
}
