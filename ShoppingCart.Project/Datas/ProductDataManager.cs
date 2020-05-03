using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Datas
{
    public class ProductDataManager : IProductDataManager
    {
        public ProductDataManager() { }
        public static UtilitiyService _uService = new UtilitiyService();


        public List<Product> GetAll()
        {
            
            var data = _uService.ReadJsonData<ProductDataModel>("Datas/Mock/Products.mock.json");

            return data != null && data.Products.Count > 0 ? data.Products.ToList() : new List<Product>();
        }

        public Product GetProductById(int id)
        {
            var data = _uService.ReadJsonData<ProductDataModel>("Datas/Mock/Products.mock.json");

            return data.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }
    }
}
