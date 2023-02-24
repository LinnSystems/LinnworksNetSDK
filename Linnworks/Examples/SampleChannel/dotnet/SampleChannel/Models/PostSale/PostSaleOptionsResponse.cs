using System.Collections.Generic;

namespace SampleChannel.Models.PostSale
{
    public class PostSaleOptionsResponse : BaseResponse
    {
        /// <summary>
        /// Determines whether the channel allows cancelling an order
        /// </summary>
        public bool CanCancel { get; set; }

        /// <summary>
        /// Determines whether the channel allows cancelling individual order lines
        /// </summary>
        public bool CanCancelOrderLines { get; set; }

        /// <summary>
        /// Determines whether the channel allows cancelling only part of an order
        /// line (not the full quantity)
        /// </summary>
        public bool CanCancelOrderLinesPartially { get; set; }

        /// <summary>
        /// Determines whether the channel will automatically refund an order when
        /// it is cancelled. When enabled, this will create a processed refund in
        /// Linnworks when an order is cancelled
        /// </summary>
        public bool AutomaticRefundOnCancel { get; set; }

        /// <summary>
        /// Determines whether the channel allows refunding an order
        /// </summary>
        public bool CanRefund { get; set; }

        /// <summary>
        /// Determines whether the channel allows attaching refunds to a particular
        /// order line
        /// </summary>
        public bool CanAttachRefundToItem { get; set; }

        /// <summary>
        /// Determines whether the channel allows attaching refunds to service lines
        /// </summary>
        public bool CanAttachRefundToService { get; set; }

        /// <summary>
        /// Determines how the channel deals with shipping refunds <see cref="ShippingRefundType"/>
        /// </summary>
        public ShippingRefundType RefundShippingTypes { get; set; }

        /// <summary>
        /// Determines whether the channel allows creating refunds independent of any
        /// items/shipping
        /// </summary>
        public bool CanRefundAdditionally { get; set; }

        /// <summary>
        /// Determines whether the channel allows creating returns
        /// </summary>
        public bool CanReturn { get; set; }

        /// <summary>
        /// Provides a list of reasons for post sale actions
        /// </summary>
        public List<PostSaleReasons> PostSaleReasons { get; set; }

    }
}
