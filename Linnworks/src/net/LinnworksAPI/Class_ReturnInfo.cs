using System;

namespace LinnworksAPI
{
    public class ReturnInfo
    {
        public Int32 pkReturnId;
        public ReturnType RowType;
        public String ReturnReference;
        public Guid fkOrderId;
        public Guid fkOrderItemRowId;
        public Int32 nOrderId;
        public String SKU;
        public String ItemTitle;
        public String Reason;
        public String ChannelReason;
        public String ChannelReasonSec;
        public String Category;
        public Int32 ReturnQty;
        public Guid fkReturnLocationId;
        public Boolean Scrapped;
        public Int32 ScrapQty;
        public String LastState;
        public DateTime LastDate;
        public Boolean Completed;
        public Guid fkNewOrderId;
        public Guid fkNewOrderItemRowId;
        public Guid fkNewStockItemId;
        public Int32 NewQty;
        public Int32 NewOrderId;
        public Boolean NewOrderCancelled;
        public String NewSKU;
        public String NewItemTitle;
        public DateTime NewOrderProcessedOn;
        public Double AdditionalCost;
        public Guid fkRefundRowId;
        public Double RefundedAmount;
        public Double PendingRefund;
        public DateTime ReturnDate;
    }
}