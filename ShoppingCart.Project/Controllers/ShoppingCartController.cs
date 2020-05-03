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
        private readonly ICampaignService _campaignService;

        public ShoppingCartController(ILogger<ShoppingCartController> logger, IShoppingCartService shoppingCartService, ICustomerService customerService,IProductsService productsService, ICampaignService campaignService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
            _customerService = customerService;
            _productsService = productsService;
            _campaignService = campaignService;
        }

        [HttpPost]
        public IActionResult Post(ShoppingCartRequestModel Request)
        {

            if (Request.CartId == 0 || Request.SessionId == null)
            {
                return BadRequest(new { BadRequest = "CardId OR SessionId cannot null" });
            }

            //sample creating a new category (
            var currentProduct = _productsService.GetProductById(Request.Product.Id);
            var currentCustomer =  _customerService.GetCustomer(Request.SessionId);

            if (currentProduct == null && currentProduct.Category == null)
            {
                return StatusCode(StatusCodes.Status409Conflict, new { error = "" });
            }
            var cart = new CartModel()
            {
                Product = new ProductModel()
                {
                    Category = currentProduct.Category,
                    Price = currentProduct.Price,
                    ProductId = currentProduct.ProductId,
                    Title = currentProduct.Title
                },
                Quantity = Request.Quantity,
                SessionId = Request.SessionId
            };


            //same category count
            var lastOrderCount = currentCustomer.Orders.Where(x => x.CategoryId == currentProduct.Category.CategoryId).Count();


            var currentCampaigns = _campaignService.GetCampaign(currentProduct.Category.CategoryId);

            if (currentCampaigns.Count > 0)
            {
               var campaignDiscount = _shoppingCartService.getCampaignDiscount(currentCampaigns, cart);

                _shoppingCartService.applyDiscounts(campaignDiscount);
            }


           
            //currentCoupons = ...

            var totalDiscount = 0;
            var totalPrice = 0;
            var unitPrice = currentProduct.Price;

            //Products can be added to a shopping cart with quantity 
            var currentCart = _shoppingCartService.AddItem(cart);



            var Response = new ShoppingCartResponseModel()
            {
                CategoryName = currentCart.Product.Category.Title,
                ProductName = currentCart.Product.Title,
                Quantity = Request.Quantity,
                TotalDiscount = totalDiscount,
                TotalPrice = totalPrice,
                UnitPrice = unitPrice
            };

            return Ok(new {
                Status = "OK" ,
                ResponseCode = HttpContext.Response.StatusCode,
                Data  = Response
            });
        }

        [HttpGet]
        public IActionResult Get()
        {

            //TODO: will be make a CurrentcardItemList
            return Ok( new {  CurrentcardItemList = "CurrentcardItemList" });
        }



    }
}
