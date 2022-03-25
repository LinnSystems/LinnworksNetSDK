namespace SampleChannel.Models.Shipping
{
    public class ShippingTag
    {
        /// <summary>
        /// The shipping tag that is supplied on the order.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Friendly name of the shipping tag.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Site of the shipping tag, this is usually used when the channel has one set of credentials
        /// however has multiple sites for example UK, DE, US and so on. Leave blank if this is not applicable.
        /// </summary>
        public string Site { get; set; }
    }
}