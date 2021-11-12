using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Products
{
    public class ProductInventoryUpdateRequest : BaseRequest
    {
        /// <summary>
        /// List of products <see cref="ProductInventory"/>
        /// </summary>
        public ProductInventory[] Products { get; set; }
    }
}