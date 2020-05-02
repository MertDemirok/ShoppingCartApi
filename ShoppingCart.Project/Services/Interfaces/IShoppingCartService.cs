using System;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Services.Interfaces
{
    public interface IShoppingCartService
    {
        void AddItem(CartModel newItem);
    }
}
