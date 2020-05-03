using System;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class DeliveryCostCalculatorService : IDeliveryCostCalculatorService
    {
        public DeliveryCostCalculatorService()
        {
        }

        public double calculateFor(CartModel card)
        {
            return 0;
        }
    }
}
