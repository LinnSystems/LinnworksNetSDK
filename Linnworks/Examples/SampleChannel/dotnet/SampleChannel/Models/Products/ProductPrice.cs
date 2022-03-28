namespace SampleChannel.Models.Products
{
    public class ProductPrice
    {
        /// <summary>
        /// Product SKU.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// New price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Price tag, this is free text but can be used to identify different types of Prices for
        /// example the Price with no tag could be current selling price, and a tag submitted with
        /// "RETAILPRICE" could be the retail price.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Product Reference, e.g. Internal product id.
        /// </summary>
        public string Reference { get; set; }
    }
}