using System;
namespace ShoppingCart.Project.Models
{
    public class CampaignModel
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
