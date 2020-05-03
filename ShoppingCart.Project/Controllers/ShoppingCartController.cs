using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using ShoppingCart.Project.Models;
using ShoppingCart.Project.Services.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingCartController : ControllerBase
    {

        private readonly ILogger<ShoppingCartController> _logger;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly ICustomerService _customerService;
        private readonly IProductsService _productsService;

        public ShoppingCartController(ILogger<ShoppingCartController> logger, IShoppingCartService shoppingCartService, ICustomerService customerService,IProductsService productsService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
            _customerService = customerService;
            _productsService = productsService;
        }

        [HttpPost]
        public IActionResult Post(ShoppingCartRequestModel Request)
        {

            if (Request.CartId == 0 || Request.SessionId == null)
            {
                return BadRequest(new { BadRequest = "CardId OR SessionId cannot null" });
            }

            //TODO: session id ver cart id ile customerı kontrol et gelen customerın eskı orderını kontrol et
            //TODO:  customerın orderlarının hangı kategorıden alındıgı mıktarı ?
            //TODO:  customer dummy datası yarat
            //TODO:  teknik olarak projeı olgunlastır. Attrıbute valitation error handle vs.




            //sample creating a new category (I chose get a category with product dummy data )
            var result = _productsService.GetProductById(Request.Product.Id);

            //Products can be added to a shopping cart with quantity 
            var currentCart = _shoppingCartService.AddItem(new CartModel()
            {
                Product = new ProductModel()
                {
                    Category = result.Category,
                    Price = result.Price,
                    ProductId = result.ProductId,
                    Title = result.Title
                }
            });

            if (result == null && result.Category == null )
            {
                return StatusCode(StatusCodes.Status409Conflict,new { error= ""});
            }

            //TODO: 0 alanları dolacak
            var Response = new ShoppingCartResponseModel()
            {
                CategoryName = currentCart.Product.Category.Title,
                ProductName = currentCart.Product.Title,
                Quantity = Request.Quantity,
                TotalDiscount = 0,
                TotalPrice = 0,
                UnitPrice = 0
            };
            

            return Ok(new {Status = "OK" ,ResponseCode = HttpContext.Response.StatusCode, Data  = Response });
        }

        [HttpGet]
        public IActionResult Get()
        {

            //TODO: will be make a CurrentcardItemList
            return Ok( new {  CurrentcardItemList = "CurrentcardItemList" });
        }



    }
}
