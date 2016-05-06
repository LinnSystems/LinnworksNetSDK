using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class Create_PurchaseOrder_InitialParameter
{ public Guid fkSupplierId;
public Guid fkLocationId;
public DateTime DateOfPurchase;
public DateTime QuotedDeliveryDate;
public String ExternalInvoiceNumber;
public Double PostagePaid;
public String Currency;
public Double ShippingTaxRate;
public Double ConversionRate;
public String SupplierReferenceNumber;
 
} 
}