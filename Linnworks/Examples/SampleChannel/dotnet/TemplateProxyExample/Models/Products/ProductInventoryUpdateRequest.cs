using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductInventoryUpdateRequest : BaseRequest
    {
        public ProductInventory[] Products { get; set; }
    }
}