using System;
namespace ShoppingCart.Project.Utilities
{
    public interface IExternalService
    {
        T BasicJsonRequest<T>(string baseUrl, string resource);
    }
}
