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

        /// <summary>
        /// Current page number in the fetch sequence, starts from 1.
        /// </summary>
        public int PageNumber { get; set; }
    }
}