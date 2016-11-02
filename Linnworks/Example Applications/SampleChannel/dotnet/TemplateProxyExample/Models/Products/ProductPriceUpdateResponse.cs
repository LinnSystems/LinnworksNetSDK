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
            this.Products = new List<ProductPriceError>();
        }
        public List<ProductPriceError> Products { get; set; }
    }
}