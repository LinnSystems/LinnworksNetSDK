using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductPrice
    {
        public string SKU { get; set; }
        public decimal Price { get; set; }
        public string Tag { get; set; }
        public string Reference { get; set; }
    }
}