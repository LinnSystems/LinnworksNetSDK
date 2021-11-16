using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductPriceResponse : BaseResponse
    {
        /// <summary>
        /// Product Unique SKU
        /// </summary>
        public string SKU { get; set; }
    }
}