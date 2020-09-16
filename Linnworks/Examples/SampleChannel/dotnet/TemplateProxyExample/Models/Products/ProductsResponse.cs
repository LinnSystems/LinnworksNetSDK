using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductsResponse : BaseResponse
    {
        public bool HasMorePages { get; set; }
        public Product[] Products { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public bool HasProducts { get { return this.Products != null && this.Products.Length > 0; } }
    }
}