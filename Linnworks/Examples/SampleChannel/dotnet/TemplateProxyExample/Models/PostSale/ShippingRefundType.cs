using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateProxyExample.Models.PostSale
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
