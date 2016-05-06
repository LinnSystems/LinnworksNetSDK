using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class StockItemLevel
{ public StockLocation Location;
public Int32 StockLevel;
public Double StockValue;
public Int32 MinimumLevel;
public Int32 InOrders;
public Int32 Available;
public Int32 Due;
public Double UnitCost;
public Guid StockItemId;
 
} 
}