using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Payment
{
    public class PaymentTagResponse : BaseResponse
    {
        /// <summary>
        /// List of payment tags.
        /// </summary>
        public PaymentTag[] PaymentTags { get; set; }
    }
}