using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Shipping
{
    public class ShippingTagResponse : BaseResponse
    {
        public ShippingTag[] ShippingTags { get; set; }
    }
}