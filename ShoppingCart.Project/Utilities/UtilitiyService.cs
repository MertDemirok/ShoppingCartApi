using System;
using System.Collections.Generic;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Utilities
{
    public class UtilitiyService
    {
        private static ExternalService _externalService;

        public UtilitiyService()
        {
            
        }

        public List<Value> GetTrendyolCategoryList(string name)
        {
            _externalService = new ExternalService();
           

            //TODO: parameter will be dynamic
            var response = _externalService.BasicJsonRequest<TrendData>
                ("https://api.trendyol.com", "/websearchgw/api/aggregations/" + fixedText(name));

            List<Value> category = new List<Value>();
            foreach (var item in response.Result.Aggregations)
            {
                if (item.Group == "CATEGORY")
                {
                    category = item.Values;

                }
            }

            return category;
        }

        public string fixedText(string text)
        {
            var retval = "";

            //kadin+ayakkabi"
            if (!text.Contains("+"))
            {
               retval  = text.Replace(" ", "+");
            }
            return retval;
        }


    }
}
