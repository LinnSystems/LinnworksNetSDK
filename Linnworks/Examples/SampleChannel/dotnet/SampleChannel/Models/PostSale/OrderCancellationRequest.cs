using System.Collections.Generic;

namespace SampleChannel.Models.PostSale
{
    public class OrderCancellation
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
        /// A collection of order items to cancel on the marketplace.
        /// </summary>
        public List<OrderCancellationItem> Items { get; set; }
    }

    public class OrderCancellationItem
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
        /// The quantity of this item to submit for cancellation.
        /// </summary>
        public int CancellationQuantity { get; set; }

        /// <summary>
        /// If the marketplace supports tag-based cancellation reasons, this field will contain the selected tag. Otherwise, it will include the freetext reason submitted by the customer.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// If the marketplace supports tag-based cancellation reasons, this field will contain the selected sub-tag.
        /// </summary>
        public string SecondaryReason { get; set; }
    }

    public class OrderCancelRequest : BaseRequest
    {
        public OrderCancellation Cancellation { get; set; }
    }
}
