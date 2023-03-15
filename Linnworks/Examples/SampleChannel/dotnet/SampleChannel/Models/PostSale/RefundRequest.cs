using System.Collections.Generic;

namespace SampleChannel.Models.PostSale
{
    public class OrderRefund
    {
        /// <summary>
        /// The order reference number within Linnworks.
        /// </summary>
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The external reference number within Linnworks. This is usually the marketplace reference.
        /// </summary>
        public string ExternalReference { get; set; }

        /// <summary>
        /// The amount to refund for shipping.
        /// </summary>
        public decimal RefundShippingAmount { get; set; }

        /// <summary>
        /// A collection of order items to refund on the marketplace.
        /// </summary>
        public List<OrderRefundItem> Items { get; set; }
    }

    public class OrderRefundItem
    {
        /// <summary>
        /// The unique Linnworks SKU of the item.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// The order item number for this item. This is usually the marketplace ID for the order item.
        /// </summary>
        public string OrderLineNumber { get; set; }

        /// <summary>
        /// The amount to submit as a refund for this item.
        /// </summary>
        public decimal RefundAmount { get; set; }

        /// <summary>
        /// If the marketplace supports tag-based refund reasons, this field will contain the selected tag. Otherwise, it will include the freetext reason submitted by the customer.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// If the marketplace supports tag-based refund reasons, this field will contain the selected sub-tag.
        /// </summary>
        public string SecondaryReason { get; set; }
    }

    public class OrderRefundRequest : BaseRequest
    {
        public OrderRefund Refund { get; set; }
    }
}
