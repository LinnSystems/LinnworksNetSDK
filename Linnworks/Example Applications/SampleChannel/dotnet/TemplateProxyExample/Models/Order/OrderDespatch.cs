using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateProxyExample.Models.Order
{
    public class OrderDespatch
    {
        public string ReferenceNumber { get; set; }
        public string ShippingVendor { get; set; }
        public string ShippingMethod { get; set; }
        public string TrackingNumber { get; set; }
        public string[] SecondaryTrackingNumbers { get; set; }
        public System.DateTime ProcessedOn { get; set; }
        public OrderDespatchItem[] Items { get; set; }
    }
}