using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class StockItemDuePO
{ public String SupplierName;
public StockLocation Location;
public Guid SupplierId;
public DateTime DateOfPurchase;
public DateTime QuotedDeliveryDate;
public Int32 Quantity;
public Int32 Delivered;
public Double UnitCost;
public Guid StockItemId;
 
} 
}