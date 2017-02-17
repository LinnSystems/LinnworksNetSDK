using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TemplateProxyExample.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpPost()]
        [ActionName("Products")]
        public Models.Products.ProductsResponse Products(Models.Products.ProductsRequest request)
        {
            if (request.PageNumber <= 0)
                return new Models.Products.ProductsResponse { Error = "Invalid page number" };

            var user = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (user == null)
                return new Models.Products.ProductsResponse { Error = "User not found" };

            Random rand = new Random(DateTime.UtcNow.Millisecond);

            var products = new List<Models.Products.Product>();

            int productCount = 1000;
            if (request.PageNumber == 11)
            {
                productCount = 22;
            }
            else if (request.PageNumber > 11)
            {
                productCount = 0;
            }

            for (int i = 1; i <= productCount; i++)
            {
                products.Add(new Models.Products.Product
                {
                    SKU = string.Concat("ChannelProduct_", i * request.PageNumber),
                    Title = string.Concat("Channel Tile of product ChannelProduct_", i * request.PageNumber),
                    Price = (decimal)rand.NextDouble(),
                    Quantity = rand.Next(0, 100)
                });
            }

            return new Models.Products.ProductsResponse
            {
                Products = products.ToArray(),
                HasMorePages = request.PageNumber < 11
            };
        }

        [HttpPost()]
        [ActionName("InventoryUpdate")]
        public Models.Products.ProductInventoryUpdateResponse InventoryUpdate(Models.Products.ProductInventoryUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductInventoryUpdateResponse { Error = "Products not supplied" };

            var user = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (user == null)
                return new Models.Products.ProductInventoryUpdateResponse { Error = "User not found" };


            var response = new Models.Products.ProductInventoryUpdateResponse();

            foreach(var product in request.Products)
            {
                if(product.SKU == "MyNonExistantSKU")
                {
                    response.Products.Add(new Models.Products.ProductInventoryResponse { SKU = product.SKU, Error = "SKU does not exist" });
                }
            }
            return response;
        }

        [HttpPost()]
        [ActionName("PriceUpdate")]
        public Models.Products.ProductPriceUpdateResponse PriceUpdate(Models.Products.ProductPriceUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductPriceUpdateResponse { Error = "Products not supplied" };

            var user = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (user == null)
                return new Models.Products.ProductPriceUpdateResponse { Error = "User not found" };


            var response = new Models.Products.ProductPriceUpdateResponse();

            foreach (var product in request.Products)
            {
                if (product.SKU == "MyNonExistantSKU")
                {
                    response.Products.Add(new Models.Products.ProductPriceResponse { SKU = product.SKU, Error = "SKU does not exist" });
                }
            }
            return response;
        }
    }
}
