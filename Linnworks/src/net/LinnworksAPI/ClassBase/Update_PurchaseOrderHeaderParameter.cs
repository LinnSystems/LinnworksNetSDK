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
	public class Update_PurchaseOrderHeaderParameter
	{ 
		public Guid pkPurchaseID;
		public String SupplierReferenceNumber;
		public Guid? fkLocationId;
		public Guid? fkSupplierId;
		public String Currency;
		public String ExternalInvoiceNumber;
		public DateTime? DateOfPurchase;
		public DateTime? QuotedDeliveryDate;
		public Decimal? ShippingTaxRate;
		public Decimal? ConversionRate;
		public Decimal? PostagePaid;
	} 
}