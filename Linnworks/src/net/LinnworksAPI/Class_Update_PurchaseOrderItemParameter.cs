using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class Update_PurchaseOrderItemParameter
{ public Guid pkPurchaseItemId;
public Guid pkPurchaseId;
public Int32? Quantity;
public Double? Cost;
public Double? TaxRate;
public Int32? PackQuantity;
public Int32? PackSize;
 
} 
}