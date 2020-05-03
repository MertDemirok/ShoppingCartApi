using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Datas;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        //TODO: Discount olabılır mı dıye kontroller yap
        //TODO: önce kapmanya inidirim sonra kupon indirimi uygula
        private static double _TotalDiscount;
        private static double _TotalPrice;
        private static double _UnitPrice;
        private static int campaignLimit = 3;
        

        public ShoppingCartService() {
            
        }

        public CartModel AddItem(CartModel newItem)
        {

            //todo: card add
            return newItem;
        }
        public CartModel GetItem(int id)
        {

            return new CartModel();
        }

        public double getCampaignDiscount(List<CampaignModel> campaign, CartModel newItem)
        {
            //Cart should apply the maximum amount of discount to the cart.
            for (int i = 0; i < campaignLimit; i++)
            {
                switch (campaign[i].Type)
                {
                    case "DiscountType.Rate":
                        _UnitPrice = newItem.Product.Price * newItem.Quantity;
                        _TotalDiscount += _UnitPrice - (_UnitPrice * campaign[i].Percent / 100);
                        break;
                    case "DiscountType.Amount":
                        
                        _TotalDiscount += campaign[i].DiscountPrice;
                        break;
                    default:
                        break;
                }

            }
            return _TotalDiscount;
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

        public void applyDiscounts(double totalDiscount) {


        }
        public void applyCoupon() {
           
        }

    }
}
