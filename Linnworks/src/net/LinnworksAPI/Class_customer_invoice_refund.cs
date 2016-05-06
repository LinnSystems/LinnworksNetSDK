using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class customer_invoice_refund
{ public Guid id;
public Guid fkInvoicePaymentId;
public Guid fkInvoiceId;
public DateTime RefundDate;
public Double RefundAmount;
public String Currency;
public String RefundReferenceNumber;
public String PaymentReference;
public String RefundAccount;
public String Comment;
 
} 
}