using System;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public CartModel AddItem(CartModel newItem)
        {
            // Gelen NEW ıtem  
            // Discount olabılır mı dıye kontroller yap
            //önce kapmanya inidirim sonra kupon indirimi uygula


            //extra
            // 
            // eklenen her urunu kaydetmeyı dene bır sonrakı sefer hepsını getırsın.
            return  newItem;
        }

        public double getCampaignDiscount()
        {
            throw new NotImplementedException();
        }

        public double getCouponDiscount()
        {
            throw new NotImplementedException();
        }

        public double getDeliveryCost()
        {
            throw new NotImplementedException();
        }

        public double getTotalAmountAfterDiscounts()
        {
            throw new NotImplementedException();
        }
    }
}
