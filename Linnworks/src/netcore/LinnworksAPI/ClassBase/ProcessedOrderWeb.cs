using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ProcessedOrderWeb
	{
        /// <summary>
        /// Order ID 
        /// </summary>
		public Guid pkOrderID;

        /// <summary>
        /// Customer's shipping address 
        /// </summary>
		public String cShippingAddress;

        /// <summary>
        /// Date when order was received on a channel 
        /// </summary>
		public DateTime dReceivedDate;

        /// <summary>
        /// Date when order was processed 
        /// </summary>
		public DateTime dProcessedOn;

        /// <summary>
        /// Days elapsed between order received and order processed 
        /// </summary>
		public Double timeDiff;

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double fPostageCost;

        /// <summary>
        /// Order total charge 
        /// </summary>
		public Double fTotalCharge;

        /// <summary>
        /// Postage cost excluding tax 
        /// </summary>
		public Double PostageCostExTax;

        /// <summary>
        /// Order subtotal 
        /// </summary>
		public Double Subtotal;

        /// <summary>
        /// Order tax 
        /// </summary>
		public Double fTax;

        /// <summary>
        /// Total discount 
        /// </summary>
		public Double TotalDiscount;

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin;

        /// <summary>
        /// Country specific tax rate 
        /// </summary>
		public Double CountryTaxRate;

        /// <summary>
        /// Linnworks order ID 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// Order status 
        /// </summary>
		public Int32 nStatus;

        /// <summary>
        /// Order currency 
        /// </summary>
		public String cCurrency;

        /// <summary>
        /// Postal tracking number 
        /// </summary>
		public String PostalTrackingNumber;

        /// <summary>
        /// Country 
        /// </summary>
		public String cCountry;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Postal service code 
        /// </summary>
		public String PostalServiceCode;

        /// <summary>
        /// Courier name (e.g. DPD) 
        /// </summary>
		public String Vendor;

		public String BillingEmailAddress;

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum;

        /// <summary>
        /// An additional reference number for the order 
        /// </summary>
		public String SecondaryReference;

        /// <summary>
        /// This is an additional reference number from the sales channel, typically used by eBay 
        /// </summary>
		public String ExternalReference;

        /// <summary>
        /// Order first line of address 
        /// </summary>
		public String Address1;

        /// <summary>
        /// Order second line of address 
        /// </summary>
		public String Address2;

        /// <summary>
        /// Order third line of address 
        /// </summary>
		public String Address3;

        /// <summary>
        /// Town 
        /// </summary>
		public String Town;

        /// <summary>
        /// Region, county, area 
        /// </summary>
		public String Region;

        /// <summary>
        /// Buyer phone number 
        /// </summary>
		public String BuyerPhoneNumber;

        /// <summary>
        /// Company 
        /// </summary>
		public String Company;

        /// <summary>
        /// Order subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Channel specific name used to identify the buyer, such as a username, normally used for eBay 
        /// </summary>
		public String ChannelBuyerName;

        /// <summary>
        /// Customer channel account name 
        /// </summary>
		public String AccountName;

        /// <summary>
        /// Customer full name 
        /// </summary>
		public String cFullName;

        /// <summary>
        /// Customer email address 
        /// </summary>
		public String cEmailAddress;

        /// <summary>
        /// Post Code 
        /// </summary>
		public String cPostCode;

        /// <summary>
        /// When order was marked as PAID 
        /// </summary>
		public DateTime dPaidOn;

        /// <summary>
        /// When order was cancelled 
        /// </summary>
		public DateTime dCancelledOn;

        /// <summary>
        /// Package category 
        /// </summary>
		public String PackageCategory;

        /// <summary>
        /// Package name 
        /// </summary>
		public String PackageTitle;

        /// <summary>
        /// Items weight 
        /// </summary>
		public Double ItemWeight;

        /// <summary>
        /// Total order weight 
        /// </summary>
		public Double TotalWeight;

        /// <summary>
        /// Folder name of an order 
        /// </summary>
		public String FolderCollection;

        /// <summary>
        /// Customer billing address 
        /// </summary>
		public String cBillingAddress;

        /// <summary>
        /// Customer billing name 
        /// </summary>
		public String BillingName;

        /// <summary>
        /// Customer billing company 
        /// </summary>
		public String BillingCompany;

        /// <summary>
        /// Billing address line one 
        /// </summary>
		public String BillingAddress1;

        /// <summary>
        /// Billing address line two 
        /// </summary>
		public String BillingAddress2;

        /// <summary>
        /// Billing address line three 
        /// </summary>
		public String BillingAddress3;

        /// <summary>
        /// Billing town 
        /// </summary>
		public String BillingTown;

        /// <summary>
        /// Billing region, area, county 
        /// </summary>
		public String BillingRegion;

        /// <summary>
        /// Billing postcode 
        /// </summary>
		public String BillingPostCode;

        /// <summary>
        /// Billing country 
        /// </summary>
		public String BillingCountryName;

        /// <summary>
        /// Billing phone number 
        /// </summary>
		public String BillingPhoneNumber;

        /// <summary>
        /// If order on hold or cancelled. 
        /// </summary>
		public Boolean HoldOrCancel;

        /// <summary>
        /// If order was created from a resend 
        /// </summary>
		public Boolean IsResend;

        /// <summary>
        /// If order was created from an exchange 
        /// </summary>
		public Boolean IsExchange;

        /// <summary>
        /// Order fulfilment location 
        /// </summary>
		public String FulfilmentLocationName;
	} 
}