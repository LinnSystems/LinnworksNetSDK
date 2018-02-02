using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BookedReturnsExchangeItem
	{
        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public Guid fkOrderItemRowId;

        /// <summary>
        /// Order item batch id 
        /// </summary>
		public Int32 OrderItemBatchId;

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid? StockItemId;

        /// <summary>
        /// Batch Inventory Id 
        /// </summary>
		public Int32? BatchInventoryId;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

        /// <summary>
        /// Record type 
        /// </summary>
		public String RowType;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Return quantity 
        /// </summary>
		public Int32 ReturnQty;

        /// <summary>
        /// Maximum returned quantity 
        /// </summary>
		public Int32 MaxReturnQty;

        /// <summary>
        /// New quantity after return 
        /// </summary>
		public Int32? NewQty;

        /// <summary>
        /// New product SKU after return 
        /// </summary>
		public String NewSKU;

        /// <summary>
        /// New product title after return 
        /// </summary>
		public String NewTitle;

        /// <summary>
        /// New returned stock item ID 
        /// </summary>
		public Guid? fkNewStockItemId;

        /// <summary>
        /// Product category 
        /// </summary>
		public String Category;

        /// <summary>
        /// Return result 
        /// </summary>
		public String Reason;

        /// <summary>
        /// In which location item was returned (Location ID) 
        /// </summary>
		public Guid fkReturnLocationId;

        /// <summary>
        /// In which location item was returned (Location name) 
        /// </summary>
		public String ReturnLocation;

        /// <summary>
        /// Refund amount still pending 
        /// </summary>
		public Double? PendingRefundAmount;

        /// <summary>
        /// If return scraped 
        /// </summary>
		public Boolean Scrapped;

        /// <summary>
        /// Scraped quantity 
        /// </summary>
		public Int32? ScrapQty;

        /// <summary>
        /// Parent prder item record row ID 
        /// </summary>
		public Guid ParentOrderItemRowId;

        /// <summary>
        /// Additional cost value 
        /// </summary>
		public Double? AdditionalCost;

        /// <summary>
        /// Currency 
        /// </summary>
		public String cCurrency;

        /// <summary>
        /// Return ID 
        /// </summary>
		public Int32 pkReturnId;

        /// <summary>
        /// Channel return ID 
        /// </summary>
		public String ChannelReason;

        /// <summary>
        /// Channel secondary reason ID 
        /// </summary>
		public String ChannelReasonSec;

        /// <summary>
        /// When return was made 
        /// </summary>
		public DateTime ReturnDate;

        /// <summary>
        /// Unit value of item at time of despatch 
        /// </summary>
		public Double DespatchUnitValue;
	} 
}