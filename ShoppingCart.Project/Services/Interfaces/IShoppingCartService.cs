using System;
using System.Collections.Generic;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IShoppingCartService
    {
        CartModel AddItem(CartModel newItem);
        CartModel GetItem(int id);
        double getTotalAmountAfterDiscounts();
        double getCouponDiscount();
        double getCampaignDiscount(List<CampaignModel> campaign, CartModel newItem);
        double getDeliveryCost();
        void applyDiscounts(double totalDiscount);
        void applyCoupon();

    }
}
