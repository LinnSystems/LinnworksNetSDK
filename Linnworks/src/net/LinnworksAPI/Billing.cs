using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class BillingMethods
    {
        public static List<customer_invoice> GetCustomerInvoices(Boolean isPaid, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<customer_invoice>>(Factory.GetResponse("Billing/GetCustomerInvoices", "isPaid=" + isPaid + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<customer_invoice_line> GetCustomerInvoiceLines(Guid invoiceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<customer_invoice_line>>(Factory.GetResponse("Billing/GetCustomerInvoiceLines", "invoiceId=" + invoiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<customer_invoice_payment> GetCustomerInvoicePayments(Guid invoiceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<customer_invoice_payment>>(Factory.GetResponse("Billing/GetCustomerInvoicePayments", "invoiceId=" + invoiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<customer_invoice_refund> GetCustomerInvoiceRefunds(Guid invoiceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<customer_invoice_refund>>(Factory.GetResponse("Billing/GetCustomerInvoiceRefunds", "invoiceId=" + invoiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<customer_field_simple> GetCustomerFields(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<customer_field_simple>>(Factory.GetResponse("Billing/GetCustomerFields", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<term_register> GetTermRegister(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<term_register>>(Factory.GetResponse("Billing/GetTermRegister", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static customer GetCustomer(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<customer>(Factory.GetResponse("Billing/GetCustomer", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetCustomerInvoicePDF(Guid invoiceId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Billing/GetCustomerInvoicePDF", "invoiceId=" + invoiceId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void CancelLinnworksProfile(String name, String phone, String time, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Billing/CancelLinnworksProfile", "name=" + name + "&phone=" + phone + "&time=" + time + "", ApiToken, ApiServer);
        }
    }
}