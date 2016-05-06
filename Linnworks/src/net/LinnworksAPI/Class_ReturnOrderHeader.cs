using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class ReturnOrderHeader
{ public Guid pkOrderId;
public Int32 nOrderId;
public String Source;
public String SubSource;
public String PostalServiceName;
public String cShippingAddress;
public String cCurrency;
public DateTime dReceivedDate;
public DateTime dProcessedOn;
public Double fTotalCharge;
public String RefundLink;
 
} 
}