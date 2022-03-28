using System;

namespace SampleChannel.Models.PostSale
{
    [Flags]
    public enum ShippingRefundType
    {
        /// <summary>
        /// Shipping refunds are not supported
        /// </summary>
        NotSupported = 0,

        /// <summary>
        /// Shipping refunds are only supported when attached to an item
        /// </summary>
        TiedToItem = 1,

        /// <summary>
        /// Shipping refunds are supported as independent refunds
        /// </summary>
        Independent = 2,
    }
}
