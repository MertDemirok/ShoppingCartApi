using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IDeliveryCostCalculatorService
    {
        double calculateFor(CartModel card);
    }
}
