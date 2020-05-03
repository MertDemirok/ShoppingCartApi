using System;
using System.Collections.Generic;

namespace ShoppingCart.Project.Datas
{
    public partial class CampaignDataModel
    {
        public List<Campaign> Campaigns { get; set; }
    }

    public partial class Campaign
    {
        public int CampaignId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Desciription { get; set; }
        public string Type { get; set; }
        public int Percent { get; set; }
        public int DiscountPrice { get; set; }
        public int ItemCount { get; set; }
    }

}
