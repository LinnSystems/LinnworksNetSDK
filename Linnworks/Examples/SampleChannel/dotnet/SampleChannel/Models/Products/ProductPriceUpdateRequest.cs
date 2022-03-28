namespace SampleChannel.Models.Products
{
    public class ProductPriceUpdateRequest : BaseRequest
    {
        /// <summary>
        /// Array of product prices <see cref="ProductPrice"/>.
        /// </summary>
        public ProductPrice[] Products { get; set; }
    }
}