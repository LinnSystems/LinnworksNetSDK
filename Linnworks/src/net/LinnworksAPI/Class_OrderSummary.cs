using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class OrderSummary
{ public Guid OrderId;
public Int32 NumOrderId;
public DateTime ReceivedDate;
public DateTime ProcessDate;
public String Source;
public String CustomerName;
public Int32 NumProducts;
public Guid FulfillmentLocationId;
 
} 
}