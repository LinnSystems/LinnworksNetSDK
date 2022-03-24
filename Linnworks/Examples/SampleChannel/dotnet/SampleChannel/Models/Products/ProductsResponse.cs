using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Products
{
    public class ProductsResponse : BaseResponse
    {
        /// <summary>
        /// Indicates if more pages are expected.
        /// </summary>
        public bool HasMorePages { get; set; }

        /// <summary>
        /// Products <see cref="Product"/>
        /// </summary>
        public Product[] Products { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public bool HasProducts { get { return this.Products != null && this.Products.Length > 0; } }
    }
}