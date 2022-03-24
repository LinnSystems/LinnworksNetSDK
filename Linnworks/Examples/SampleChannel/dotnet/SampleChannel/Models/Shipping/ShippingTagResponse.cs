using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Shipping
{
    public class ShippingTagResponse : BaseResponse
    {
        /// <summary>
        /// List of shipping tags.
        /// </summary>
        public ShippingTag[] ShippingTags { get; set; }
    }
}