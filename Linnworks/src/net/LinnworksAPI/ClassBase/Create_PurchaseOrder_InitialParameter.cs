using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{ 
	public class Create_PurchaseOrder_InitialParameter
	{ 
		public Guid fkSupplierId;
		public Guid fkLocationId;
		public String ExternalInvoiceNumber;
		public String Currency;
		public String SupplierReferenceNumber;
		public DateTime DateOfPurchase;
		public DateTime QuotedDeliveryDate;
		public Decimal PostagePaid;
		public Decimal ShippingTaxRate;
		public Decimal ConversionRate;
	} 
}