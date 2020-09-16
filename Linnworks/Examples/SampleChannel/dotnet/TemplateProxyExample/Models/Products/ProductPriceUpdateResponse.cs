using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductPriceUpdateResponse : BaseResponse
    {
        public ProductPriceUpdateResponse()
        {
            this.Products = new List<ProductPriceResponse>();
        }
        public List<ProductPriceResponse> Products { get; set; }
    }
}