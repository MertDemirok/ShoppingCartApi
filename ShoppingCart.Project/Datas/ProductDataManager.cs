using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Utilities;

namespace ShoppingCart.Project.Datas
{
    public class ProductDataManager : IProductDataManager
    {
        public ProductDataManager() { }

        public List<Product> GetAll()
        {
            
            UtilitiyService uServ = new UtilitiyService();
            var data = uServ.ReadJsonData<ProductDataModel>("Datas/DummyProducts.json");

            return data != null && data.Products.Count > 0 ? data.Products.ToList() : new List<Product>();
        }

        public Product GetProductById(int id)
        {
            UtilitiyService uServ = new UtilitiyService();

            var data = uServ.ReadJsonData<ProductDataModel>("Datas/DummyProducts.json");


            return data.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }
    }
}
