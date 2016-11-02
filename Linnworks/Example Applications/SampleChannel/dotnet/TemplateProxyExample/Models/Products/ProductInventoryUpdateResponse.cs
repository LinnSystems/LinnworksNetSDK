using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductInventoryUpdateResponse : BaseResponse
    {
        public ProductInventoryUpdateResponse()
        {
            this.Products = new List<ProductInventoryError>();
        }

        public List<ProductInventoryError> Products { get; set; }
    }
}