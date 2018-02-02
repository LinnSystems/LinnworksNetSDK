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
		public Int32 pkReturnId;

        /// <summary>
        /// return type (e.g. EXCHANGE) 
        /// </summary>
		public ReturnType RowType;

        /// <summary>
        /// Return reference 
        /// </summary>
		public String ReturnReference;

        /// <summary>
        /// Order ID 
        /// </summary>
		public Guid fkOrderId;

        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public Guid fkOrderItemRowId;

        /// <summary>
        /// Order item batch id 
        /// </summary>
		public Int32 OrderItemBatchId;

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

        /// <summary>
        /// Return reason 
        /// </summary>
		public String Reason;

        /// <summary>
        /// Return reason set on a channel 
        /// </summary>
		public String ChannelReason;

        /// <summary>
        /// Secondary return reason on a channel 
        /// </summary>
		public String ChannelReasonSec;

        /// <summary>
        /// Category 
        /// </summary>
		public String Category;

        /// <summary>
        /// Returned quantity 
        /// </summary>
		public Int32 ReturnQty;

        /// <summary>
        /// Return location ID 
        /// </summary>
		public Guid? fkReturnLocationId;

        /// <summary>
        /// If returned item was scrapped 
        /// </summary>
		public Boolean Scrapped;

        /// <summary>
        /// Scrapped quantity 
        /// </summary>
		public Int32? ScrapQty;

        /// <summary>
        /// Last state 
        /// </summary>
		public String LastState;

        /// <summary>
        /// Last date 
        /// </summary>
		public DateTime LastDate;

        /// <summary>
        /// If return is completed 
        /// </summary>
		public Boolean Completed;

        /// <summary>
        /// New order ID for return 
        /// </summary>
		public Guid? fkNewOrderId;

        /// <summary>
        /// New order item record row ID 
        /// </summary>
		public Guid? fkNewOrderItemRowId;

        /// <summary>
        /// New stock item ID 
        /// </summary>
		public Guid? fkNewStockItemId;

        /// <summary>
        /// New return quantity 
        /// </summary>
		public Int32? NewQty;

        /// <summary>
        /// New order ID 
        /// </summary>
		public Int32? NewOrderId;

        /// <summary>
        /// If new order were cancelled 
        /// </summary>
		public Boolean NewOrderCancelled;

        /// <summary>
        /// new product SKU 
        /// </summary>
		public String NewSKU;

        /// <summary>
        /// New product title 
        /// </summary>
		public String NewItemTitle;

        /// <summary>
        /// When new order was processed 
        /// </summary>
		public DateTime? NewOrderProcessedOn;

        /// <summary>
        /// Additional costs involved 
        /// </summary>
		public Double? AdditionalCost;

        /// <summary>
        /// Refund record row ID 
        /// </summary>
		public Guid? fkRefundRowId;

        /// <summary>
        /// Amount refunded 
        /// </summary>
		public Double? RefundedAmount;

        /// <summary>
        /// Refund pending 
        /// </summary>
		public Double? PendingRefund;

        /// <summary>
        /// Return date 
        /// </summary>
		public DateTime ReturnDate;
	} 
}