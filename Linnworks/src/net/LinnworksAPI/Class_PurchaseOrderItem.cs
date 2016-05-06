using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class PurchaseOrderItem
{ public Guid pkPurchaseItemId;
public Guid fkStockItemId;
public Int32 Quantity;
public Double Cost;
public Int32 Delivered;
public Double TaxRate;
public Double Tax;
public Int32 PackQuantity;
public Int32 PackSize;
public String SKU;
public String ItemTitle;
 
} 
}