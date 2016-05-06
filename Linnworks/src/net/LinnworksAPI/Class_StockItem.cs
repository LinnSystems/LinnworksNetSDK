using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class StockItem
{ public String ItemNumber;
public String ItemTitle;
public String BarcodeNumber;
public Double PurchasePrice;
public Double RetailPrice;
public Int32 Quantity;
public Double TaxRate;
public Int32 InOrder;
public Int32 Due;
public Int32 MinimumLevel;
public Int32 Available;
public Guid StockItemId;
 
} 
}