using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Datas
{
    public interface ICampaignDataManager
    {

        List<Campaign> GetCampaignWithCategoryId(int id);
    }
}
