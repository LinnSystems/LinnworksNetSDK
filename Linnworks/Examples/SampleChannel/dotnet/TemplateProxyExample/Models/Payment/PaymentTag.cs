using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Payment
{
    public class PaymentTag
    {
        /// <summary>
        /// The payment tag that is supplied on the order.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Friendly name of the payment tag.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Site of the payment tag, this is usually used when the channel has one set of credentials
        /// however has multiple sites for example UK, DE, US and so on. Leave blank if this is not applicable.
        /// </summary>
        public string Site { get; set; }
    }
}