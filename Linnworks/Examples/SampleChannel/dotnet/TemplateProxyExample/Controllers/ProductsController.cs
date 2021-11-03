using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TemplateProxyExample.Config;

namespace TemplateProxyExample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : BaseController
    {
        public ProductsController(IOptions<AppSettings> config) : base(config)
        {
        }

        [HttpPost]
        public Models.Products.ProductsResponse Products([FromBody] Models.Products.ProductsRequest request)
        {
            if (request.PageNumber <= 0)
                return new Models.Products.ProductsResponse { Error = "Invalid page number" };

            var user = Models.User.UserConfig.Load(this.UserStoreLocation, request.AuthorizationToken);

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

        [HttpPost]
        public Models.Products.ProductInventoryUpdateResponse InventoryUpdate([FromBody] Models.Products.ProductInventoryUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductInventoryUpdateResponse { Error = "Products not supplied" };

            var user = Models.User.UserConfig.Load(this.UserStoreLocation, request.AuthorizationToken);

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

        [HttpPost]
        public Models.Products.ProductPriceUpdateResponse PriceUpdate([FromBody] Models.Products.ProductPriceUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductPriceUpdateResponse { Error = "Products not supplied" };

            var user = Models.User.UserConfig.Load(this.UserStoreLocation, request.AuthorizationToken);

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
