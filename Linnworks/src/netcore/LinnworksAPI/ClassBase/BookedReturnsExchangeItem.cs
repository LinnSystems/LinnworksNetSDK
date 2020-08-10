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
		public Guid fkOrderItemRowId { get; set; }

        /// <summary>
        /// Order item batch id 
        /// </summary>
		public Int32 OrderItemBatchId { get; set; }

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid? StockItemId { get; set; }

        /// <summary>
        /// Batch Inventory Id 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Record type 
        /// </summary>
		public String RowType { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Product title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Return quantity 
        /// </summary>
		public Int32 ReturnQty { get; set; }

        /// <summary>
        /// Maximum returned quantity 
        /// </summary>
		public Int32 MaxReturnQty { get; set; }

        /// <summary>
        /// New quantity after return 
        /// </summary>
		public Int32? NewQty { get; set; }

        /// <summary>
        /// New product SKU after return 
        /// </summary>
		public String NewSKU { get; set; }

        /// <summary>
        /// New product title after return 
        /// </summary>
		public String NewTitle { get; set; }

        /// <summary>
        /// New returned stock item ID 
        /// </summary>
		public Guid? fkNewStockItemId { get; set; }

        /// <summary>
        /// Product category 
        /// </summary>
		public String Category { get; set; }

        /// <summary>
        /// Return result 
        /// </summary>
		public String Reason { get; set; }

        /// <summary>
        /// In which location item was returned (Location ID) 
        /// </summary>
		public Guid fkReturnLocationId { get; set; }

        /// <summary>
        /// In which location item was returned (Location name) 
        /// </summary>
		public String ReturnLocation { get; set; }

        /// <summary>
        /// Refund amount still pending 
        /// </summary>
		public Double? PendingRefundAmount { get; set; }

        /// <summary>
        /// If return scraped 
        /// </summary>
		public Boolean Scrapped { get; set; }

        /// <summary>
        /// Scraped quantity 
        /// </summary>
		public Int32? ScrapQty { get; set; }

        /// <summary>
        /// Parent prder item record row ID 
        /// </summary>
		public Guid ParentOrderItemRowId { get; set; }

        /// <summary>
        /// Additional cost value 
        /// </summary>
		public Double? AdditionalCost { get; set; }

        /// <summary>
        /// Currency 
        /// </summary>
		public String cCurrency { get; set; }

        /// <summary>
        /// Return ID 
        /// </summary>
		public Int32 pkReturnId { get; set; }

        /// <summary>
        /// Channel return ID 
        /// </summary>
		public String ChannelReason { get; set; }

        /// <summary>
        /// Channel secondary reason ID 
        /// </summary>
		public String ChannelReasonSec { get; set; }

        /// <summary>
        /// When return was made 
        /// </summary>
		public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Unit value of item at time of despatch 
        /// </summary>
		public Double DespatchUnitValue { get; set; }

        /// <summary>
        /// The batch inventory selected 
        /// </summary>
		public StockItemBatchInventory BatchInventory { get; set; }
	} 
}