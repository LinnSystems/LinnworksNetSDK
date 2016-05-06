using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class Add_PurchaseOrderItemParameter
{ public Guid pkPurchaseId;
public Guid fkStockItemId;
public Int32 Qty;
public Double Cost;
public Double TaxRate;
public Int32 PackQuantity;
public Int32 PackSize;
 
} 
}