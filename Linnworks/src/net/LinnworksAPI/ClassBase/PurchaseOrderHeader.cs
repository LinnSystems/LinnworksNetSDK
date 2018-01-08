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
	public class PurchaseOrderHeader
	{ 
		public Guid pkPurchaseID;
		public Guid fkSupplierId;
		public Guid fkLocationId;
		public String ExternalInvoiceNumber;
		public PurchaseOrderStatus Status;
		public String Currency;
		public String SupplierReferenceNumber;
		public Boolean Locked;
		public Int32 LineCount;
		public Int32 DeliveredLinesCount;
		public DateTime DateOfPurchase;
		public DateTime DateOfDelivery;
		public DateTime QuotedDeliveryDate;
		public Decimal PostagePaid;
		public Decimal TotalCost;
		public Decimal taxPaid;
		public Decimal ShippingTaxRate;
		public Decimal ConversionRate;
	} 
}