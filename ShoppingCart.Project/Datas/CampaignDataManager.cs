using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Datas
{
    public class CampaignDataManager : ICampaignDataManager
    {
        public static UtilitiyService _uService = new UtilitiyService();
        public CampaignDataManager()
        {
        }
        public List<Campaign> GetCampaignWithCategoryId(int id)
        {
            var data = _uService.ReadJsonData<CampaignDataModel>("Datas/Mock/Campaigns.mock.json");

            return data.Campaigns.Where(x => x.CategoryId == id).ToList();
        }

    }
}
