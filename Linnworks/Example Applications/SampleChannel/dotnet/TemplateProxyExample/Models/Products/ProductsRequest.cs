using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductsRequest : BaseRequest
    {
        public ProductsRequest()
        {
            this.PageNumber = 1;
        }

        public int PageNumber { get; set; }
    }
}