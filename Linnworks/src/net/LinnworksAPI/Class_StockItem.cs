using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class StockItem
{ public List<StockItemSupplierStat> Suppliers;
public List<StockItemLevel> StockLevels;
public String ItemNumber;
public String ItemTitle;
public String BarcodeNumber;
public String MetaData;
public Double PurchasePrice;
public Double RetailPrice;
public Double TaxRate;
public Int32 Quantity;
public Int32 InOrder;
public Int32 Due;
public Int32 MinimumLevel;
public Int32 Available;
public Guid PostalServiceId;
public String PostalServiceName;
public Guid CategoryId;
public String CategoryName;
public Guid PackageGroupId;
public String PackageGroupName;
public Double Height;
public Double Width;
public Double Depth;
public Double Weight;
public Guid StockItemId;
 
} 
}