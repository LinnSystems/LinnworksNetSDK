using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Payment
{
    public class PaymentTagResponse : BaseResponse
    {
        public PaymentTag[] PaymentTags { get; set; }
    }
}