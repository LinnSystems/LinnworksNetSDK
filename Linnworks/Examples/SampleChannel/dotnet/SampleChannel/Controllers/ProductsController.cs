using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleChannel.Adapters;

namespace SampleChannel.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private IUserConfigAdapter _userConfigAdapter;

        public ProductsController(IUserConfigAdapter userConfigAdapter)
        {
            this._userConfigAdapter = userConfigAdapter;
        }

        /// <summary>
        /// This call is used to get a list of Channel products for the purpose of mapping.
        /// </summary>
        /// <param name="request"><see cref="Models.Products.ProductsRequest"/></param>
        /// <returns><see cref="Models.Products.ProductsResponse"/></returns>
        [HttpPost]
        public Models.Products.ProductsResponse Products([FromBody] Models.Products.ProductsRequest request)
        {
            if (request.PageNumber <= 0)
                return new Models.Products.ProductsResponse { Error = "Invalid page number" };

            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

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
            catch(Exception ex)
            {
                return new Models.Products.ProductsResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This call is made when inventory is updated in Linnworks and is required to push to the channel.
        /// </summary>
        /// <param name="request"><see cref="Models.Products.ProductInventoryUpdateRequest"/></param>
        /// <returns><see cref="Models.Products.ProductInventoryUpdateResponse"/></returns>
        [HttpPost]
        public Models.Products.ProductInventoryUpdateResponse InventoryUpdate([FromBody] Models.Products.ProductInventoryUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductInventoryUpdateResponse { Error = "Products not supplied" };

            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

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
            catch (Exception ex)
            {
                return new Models.Products.ProductInventoryUpdateResponse { Error = ex.Message };
            }
        }

        /// <summary>
        /// This call is made when inventory price is updated in linnworks and is required to push to the channel.
        /// </summary>
        /// <param name="request"><see cref="Models.Products.ProductPriceUpdateRequest"/></param>
        /// <returns><see cref="Models.Products.ProductPriceUpdateResponse"/></returns>
        [HttpPost]
        public Models.Products.ProductPriceUpdateResponse PriceUpdate([FromBody] Models.Products.ProductPriceUpdateRequest request)
        {
            if (request.Products == null || request.Products.Length == 0)
                return new Models.Products.ProductPriceUpdateResponse { Error = "Products not supplied" };

            try
            {
                var user = this._userConfigAdapter.Load(request.AuthorizationToken);

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
            catch (Exception ex)
            {
                return new Models.Products.ProductPriceUpdateResponse { Error = ex.Message };
            }
        }
    }
}
