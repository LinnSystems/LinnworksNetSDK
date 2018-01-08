using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class BookedReturnsExchangeItem
	{ 
		public Guid fkOrderItemRowId;
		public Int32 OrderItemBatchId;
		public Guid? StockItemId;
		public Int32? BatchInventoryId;
		public String BatchNumber;
		public String RowType;
		public String SKU;
		public String ItemTitle;
		public Int32 ReturnQty;
		public Int32 MaxReturnQty;
		public Int32? NewQty;
		public String NewSKU;
		public String NewTitle;
		public Guid? fkNewStockItemId;
		public String Category;
		public String Reason;
		public Guid fkReturnLocationId;
		public String ReturnLocation;
		public Double? PendingRefundAmount;
		public Boolean Scrapped;
		public Int32? ScrapQty;
		public Guid ParentOrderItemRowId;
		public Double? AdditionalCost;
		public String cCurrency;
		public Int32 pkReturnId;
		public String ChannelReason;
		public String ChannelReasonSec;
		public DateTime ReturnDate;
		public Double DespatchUnitValue;
	} 
}