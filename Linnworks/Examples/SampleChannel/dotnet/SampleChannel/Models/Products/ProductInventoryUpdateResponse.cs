using System.Collections.Generic;

namespace SampleChannel.Models.Products
{
    public class ProductInventoryUpdateResponse : BaseResponse
    {
        public ProductInventoryUpdateResponse()
        {
            this.Products = new List<ProductInventoryResponse>();
        }

        /// <summary>
        /// List of products <see cref="ProductInventoryResponse"/>
        /// </summary>
        public List<ProductInventoryResponse> Products { get; set; }
    }
}