using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Products
{
    public class ProductInventoryResponse : BaseResponse
    {
        /// <summary>
        /// Product Unique SKU, duplicates will be ignored.
        /// </summary>
        public string SKU { get; set; }
    }
}