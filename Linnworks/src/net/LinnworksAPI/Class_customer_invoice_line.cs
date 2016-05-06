using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class customer_invoice_line
{ public Guid id;
public Guid pkInvoiceLineId;
public Guid fkInvoiceId;
public String Line;
public Double Subtotal;
public Double Tax;
public Double Total;
public Guid fkProfileId;
public String ProductName;
public String ReferenceTag;
public Int32 fkApplicationSubscriptionId;
 
} 
}