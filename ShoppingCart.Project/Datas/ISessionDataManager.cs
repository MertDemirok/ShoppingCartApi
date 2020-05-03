using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Datas
{
    public interface ISessionDataManager
    {
        List<SessionDataModel> GetAll();
        SessionDataModel GetSessionById(string id);
    }
}
