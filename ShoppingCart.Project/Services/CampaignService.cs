using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Datas;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignDataManager  _campaignDataManager = new CampaignDataManager();
        public CampaignService()
        {
        }

        public List<CampaignModel> GetCampaign(int id)
        {
           var result =  _campaignDataManager.GetCampaignWithCategoryId(id);

            return result.Select(x => new CampaignModel()
            {
                CampaignId = x.CampaignId,
                CategoryId = x.CategoryId,
                Desciription = x.Desciription,
                DiscountPrice = x.DiscountPrice,
                ItemCount = x.ItemCount,
                Name = x.Name,
                Percent = x.Percent,
                Type = x.Type
            }).ToList();
        }

    }
}
