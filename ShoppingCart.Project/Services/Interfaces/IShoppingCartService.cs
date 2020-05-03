using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IShoppingCartService
    {
        CartModel AddItem(CartModel newItem);

        double getTotalAmountAfterDiscounts();
        double getCouponDiscount();
        double getCampaignDiscount();
        double getDeliveryCost();

    }
}
