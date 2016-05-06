using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class OrderPackagingSplit
{ public Guid pkBinId;
public Guid pkPostalServiceId;
public Double PackagingWeight;
public Guid fkPackagingTypeId;
public List<OrderPackagingSplitItem> Items;
public Double TotalWeight;
public String TrackingNumbers;
 
} 
}