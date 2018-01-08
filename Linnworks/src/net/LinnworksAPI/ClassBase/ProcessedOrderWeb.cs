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
	public class ProcessedOrderWeb
	{ 
		public Guid pkOrderID;
		public String cShippingAddress;
		public DateTime dReceivedDate;
		public DateTime dProcessedOn;
		public Double timeDiff;
		public Double fPostageCost;
		public Double fTotalCharge;
		public Double PostageCostExTax;
		public Double Subtotal;
		public Double fTax;
		public Double TotalDiscount;
		public Double ProfitMargin;
		public Double CountryTaxRate;
		public Int32 nOrderId;
		public Int32 nStatus;
		public String cCurrency;
		public String PostalTrackingNumber;
		public String cCountry;
		public String Source;
		public String PostalServiceName;
		public String PostalServiceCode;
		public String Vendor;
		public String ReferenceNum;
		public String SecondaryReference;
		public String ExternalReference;
		public String Address1;
		public String Address2;
		public String Address3;
		public String Town;
		public String Region;
		public String BuyerPhoneNumber;
		public String Company;
		public String SubSource;
		public String ChannelBuyerName;
		public String AccountName;
		public String cFullName;
		public String cEmailAddress;
		public String cPostCode;
		public DateTime dPaidOn;
		public DateTime dCancelledOn;
		public String PackageCategory;
		public String PackageTitle;
		public Double ItemWeight;
		public Double TotalWeight;
		public String FolderCollection;
		public String cBillingAddress;
		public String BillingName;
		public String BillingCompany;
		public String BillingAddress1;
		public String BillingAddress2;
		public String BillingAddress3;
		public String BillingTown;
		public String BillingRegion;
		public String BillingPostCode;
		public String BillingCountryName;
		public String BillingPhoneNumber;
		public Boolean HoldOrCancel;
		public Boolean IsResend;
		public Boolean IsExchange;
	} 
}