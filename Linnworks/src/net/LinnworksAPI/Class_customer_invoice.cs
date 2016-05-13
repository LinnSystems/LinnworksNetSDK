using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class customer_invoice
{ public Guid id;
public Guid pkInvoiceId;
public Guid sid_registration;
public DateTime InvoiceDate;
public DateTime PaidDate;
public DateTime? SendDate;
public Boolean Paid;
public Boolean IsReverseAllowed;
public Double Subtotal;
public Double Tax;
public Double Total;
public Double TotalPaid;
public Double TotalRefund;
public Int32 InvoiceRefNumber;
public Double TaxRate;
public String CountryCode;
public String Country;
public String currency;
public String ContactName;
public String BusinessName;
public String VATRegistration;
public String Town;
public String Address1;
public String Address2;
public String PostCode;
public String Region;
public String Email;
public String OriginalCurrency;
public Double OriginalCurrencySubtotal;
public Double OriginalCurrencyTax;
public Boolean CurrencyConverted;
 
} 
}