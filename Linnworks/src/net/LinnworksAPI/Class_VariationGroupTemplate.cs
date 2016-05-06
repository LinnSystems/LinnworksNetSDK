using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class VariationGroupTemplate
{ public String VariationGroupName;
public String ParentSKU;
public Guid ParentStockItemId;
public List<Guid> VariationItemIds;
 
} 
}