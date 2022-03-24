using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Products
{
    public class Product
    {
        /// <summary>
        /// Product Unique SKU, duplicates are not allowed.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Title of the product.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Current level on the channel.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Current price on the channel.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Reference from the channel e.g. internal product ID. This will be submitted alongside
        /// the SKU in inventory and price updates.
        /// </summary>
        public string Reference { get; set; }
    }
}