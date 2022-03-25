﻿namespace SampleChannel.Models.Products
{
    public class ProductInventoryUpdateRequest : BaseRequest
    {
        /// <summary>
        /// List of products <see cref="ProductInventory"/>
        /// </summary>
        public ProductInventory[] Products { get; set; }
    }
}