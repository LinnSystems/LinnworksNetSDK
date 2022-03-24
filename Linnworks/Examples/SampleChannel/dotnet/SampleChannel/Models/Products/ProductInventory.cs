using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Products
{
    public class ProductInventory
    {
        /// <summary>
        /// Product SKU.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Product Reference, e.g. Internal product id.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// New available quantity.
        /// </summary>
        public string Reference { get; set; }
    }
}