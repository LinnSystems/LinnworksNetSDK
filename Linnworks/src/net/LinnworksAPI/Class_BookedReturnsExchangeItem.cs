using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class BookedReturnsExchangeItem
{ public Guid fkOrderItemRowId;
public String RowType;
public String SKU;
public String ItemTitle;
public Int32 ReturnQty;
public Int32 MaxReturnQty;
public Int32 NewQty;
public String NewSKU;
public String NewTitle;
public Guid fkNewStockItemId;
public String Category;
public String Reason;
public Guid fkReturnLocationId;
public String ReturnLocation;
public Double PendingRefundAmount;
public Boolean Scrapped;
public Int32 ScrapQty;
public Guid ParentOrderItemRowId;
public Double AdditionalCost;
public String cCurrency;
public Int32 pkReturnId;
public String ChannelReason;
public String ChannelReasonSec;
public DateTime ReturnDate;
 
} 
}