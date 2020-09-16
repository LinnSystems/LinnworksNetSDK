using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductPriceUpdateRequest : BaseRequest
    {
        public ProductPrice[] Products { get; set; }
    }
}