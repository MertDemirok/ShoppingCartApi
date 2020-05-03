using System;
using System.Collections.Generic;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface ICampaignService
    {
        List<CampaignModel> GetCampaign(int id);
    }
}
