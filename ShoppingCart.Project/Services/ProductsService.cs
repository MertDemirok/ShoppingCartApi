using System;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.Project.Datas;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

namespace ShoppingCart.Project.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductDataManager _productDataManager = new ProductDataManager();

        public ProductModel GetProductById(int id)
        {
           var items =  _productDataManager.GetProductById(id);

        
            return new ProductModel() {
                ProductId = items.ProductId,
                Title = items.Name,
                Price = items.Price,
                Category = new CategoryModel()
                {
                    Title = items.Category.Title,
                    CategoryId = items.Category.Id,
                    SubCategory = items.Category.SubCategory.Select(x => new SubCategoryModel()
                    {
                        Title = x.Text,
                        SubCategoryId = x.Id,
                    }).ToList()
                }
                
            };
        }
        public List<ProductModel> GetAllProduct()
        {
            return _productDataManager.GetAll().Select( x => new ProductModel()
            {
                ProductId = x.ProductId,
                Title = x.Name,
                Price = x.Price,
                Category = new CategoryModel()
                {
                    Title = x.Category.Title,
                    CategoryId = x.Category.Id,
                    SubCategory = x.Category.SubCategory.Select(y => new SubCategoryModel()
                    {
                        Title = y.Text,
                        SubCategoryId = y.Id,
                    }).ToList()
                }

            }).ToList();
        }

        public void UpdateProduct(ProductModel product)
        {
            
        }

        public void Addroduct(ProductModel product)
        {

        }

    }
}
