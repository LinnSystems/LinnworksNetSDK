using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnInfo
	{
        /// <summary>
        /// Return ID 
        /// </summary>
		public Int32 pkReturnId { get; set; }

        /// <summary>
        /// return type (e.g. EXCHANGE) 
        /// </summary>
		public ReturnType RowType { get; set; }

        /// <summary>
        /// Return reference 
        /// </summary>
		public String ReturnReference { get; set; }

        /// <summary>
        /// Order ID 
        /// </summary>
		public Guid fkOrderId { get; set; }

        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public Guid fkOrderItemRowId { get; set; }

        /// <summary>
        /// Order item batch id 
        /// </summary>
		public Int32 OrderItemBatchId { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Return reason 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// Return reason set on a channel 
        /// </summary>
		public String ChannelReason { get; set; }

        /// <summary>
        /// Secondary return reason on a channel 
        /// </summary>
		public String ChannelReasonSec { get; set; }

        /// <summary>
        /// Category 
        /// </summary>
		public String Category { get; set; }

        /// <summary>
        /// Returned quantity 
        /// </summary>
		public Int32 ReturnQty { get; set; }

        /// <summary>
        /// Return location ID 
        /// </summary>
		public Guid? fkReturnLocationId { get; set; }

        /// <summary>
        /// If returned item was scrapped 
        /// </summary>
		public Boolean Scrapped { get; set; }

        /// <summary>
        /// Scrapped quantity 
        /// </summary>
		public Int32? ScrapQty { get; set; }

        /// <summary>
        /// Last state 
        /// </summary>
		public String LastState { get; set; }

        /// <summary>
        /// Last date 
        /// </summary>
		public DateTime LastDate { get; set; }

        /// <summary>
        /// If return is completed 
        /// </summary>
		public Boolean Completed { get; set; }

        /// <summary>
        /// New order ID for return 
        /// </summary>
		public Guid? fkNewOrderId { get; set; }

        /// <summary>
        /// New order item record row ID 
        /// </summary>
		public Guid? fkNewOrderItemRowId { get; set; }

        /// <summary>
        /// New stock item ID 
        /// </summary>
		public Guid? fkNewStockItemId { get; set; }

        /// <summary>
        /// New return quantity 
        /// </summary>
		public Int32? NewQty { get; set; }

        /// <summary>
        /// New order ID 
        /// </summary>
		public Int32? NewOrderId { get; set; }

        /// <summary>
        /// If new order were cancelled 
        /// </summary>
		public Boolean NewOrderCancelled { get; set; }

        /// <summary>
        /// new product SKU 
        /// </summary>
		public String NewSKU { get; set; }

        /// <summary>
        /// New product title 
        /// </summary>
		public String NewItemTitle { get; set; }

        /// <summary>
        /// When new order was processed 
        /// </summary>
		public DateTime? NewOrderProcessedOn { get; set; }

        /// <summary>
        /// Additional costs involved 
        /// </summary>
		public Double? AdditionalCost { get; set; }

        /// <summary>
        /// Refund record row ID 
        /// </summary>
		public Guid? fkRefundRowId { get; set; }

        /// <summary>
        /// Amount refunded 
        /// </summary>
		public Double? RefundedAmount { get; set; }

        /// <summary>
        /// Refund pending 
        /// </summary>
		public Double? PendingRefund { get; set; }

        /// <summary>
        /// Return date 
        /// </summary>
		public DateTime ReturnDate { get; set; }
	} 
}