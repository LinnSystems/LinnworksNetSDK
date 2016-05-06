using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class StockItemSoldStat
{ public String Source;
public Int32 Quantity;
public Double Total;
public Double Cost;
public Double ProfitMargin;
public List<StockItemSoldStatDetail> Detail;
public Guid StockItemId;
 
} 
}