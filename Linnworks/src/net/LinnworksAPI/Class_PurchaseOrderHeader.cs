using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class PurchaseOrderHeader
{ public Guid pkPurchaseID;
public Guid fkSupplierId;
public Guid fkLocationId;
public DateTime DateOfPurchase;
public DateTime DateOfDelivery;
public DateTime QuotedDeliveryDate;
public String ExternalInvoiceNumber;
public Double PostagePaid;
public Double TotalCost;
public Double taxPaid;
public PurchaseOrderStatus Status;
public String Currency;
public Double ShippingTaxRate;
public Double ConversionRate;
public String SupplierReferenceNumber;
public Boolean Locked;
 
} 
}