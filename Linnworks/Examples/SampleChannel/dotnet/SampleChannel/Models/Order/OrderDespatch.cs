using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChannel.Models.Order
{
    public class OrderDespatch
    {
        /// <summary>
        /// Unique reference of the order.
        /// </summary>
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Shipping Ventor / Carrier.
        /// </summary>
        public string ShippingVendor { get; set; }

        /// <summary>
        /// Linnworks shipping method.
        /// </summary>
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Tracking Number.
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Additional Tracking numbers.
        /// </summary>
        public string[] SecondaryTrackingNumbers { get; set; }

        /// <summary>
        /// Date order was processed Format: "yyyy-MM-dd HH:mm:ssZ".
        /// </summary>
        public System.DateTime ProcessedOn { get; set; }

        /// <summary>
        /// Order despatch items <see cref="OrderDespatchItem"/>.
        /// </summary>
        public OrderDespatchItem[] Items { get; set; }
    }
}