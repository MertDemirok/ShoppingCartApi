using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Datas
{
    public class SessionDataManager : ISessionDataManager
    {
        public SessionDataManager() {}
        public static UtilitiyService _uService = new UtilitiyService();

        public List<SessionDataModel> GetAll()
        {
            var data = _uService.ReadJsonData<List<SessionDataModel>>("Datas/Mock/Sessions.mock.json");

            return data.ToList();
        }

        public SessionDataModel GetSessionById(string id)
        {

            var data = _uService.ReadJsonData<List<SessionDataModel>>("Datas/Mock/Sessions.mock.json");

            return data.Where(x => x.SessionId == new Guid(id)).FirstOrDefault();
        }
    }
}
