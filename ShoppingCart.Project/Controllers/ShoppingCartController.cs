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

        public ShoppingCartController(ILogger<ShoppingCartController> logger, IShoppingCartService shoppingCartService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
        }

        [HttpPost]
        public IActionResult Post(ShoppingCartRequestModel cartItem)
        {


            var subCategoryObj = new SubCategoryModel() { };
            var categoryObj = new CategoryModel() { };
            var productObj = new ProductModel() { };


            var cartObj = new CartModel()
             {

             };

            _shoppingCartService.AddItem(new CartModel()
            {
                
            });
            /*
            if (req.CartId == 0)
            {
                return StatusCode(StatusCodes.Status409Conflict,new { error= "sıkıtnıvar"});
            }else if("" == "test")
            {
                return BadRequest(new { badreq = "sıkıtnıvar" });
            }
            */
            return Ok("");
        }

        [HttpGet]
        public IActionResult Get()
        {

            //TODO: will be make a CurrentcardItemList
            return Ok( new {  CurrentcardItemList = "CurrentcardItemList" });
        }



    }
}
