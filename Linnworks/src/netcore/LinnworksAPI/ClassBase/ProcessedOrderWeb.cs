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
		public Guid pkOrderID { get; set; }

        /// <summary>
        /// Customer's shipping address 
        /// </summary>
		public String cShippingAddress { get; set; }

        /// <summary>
        /// Date when order was received on a channel 
        /// </summary>
		public DateTime dReceivedDate { get; set; }

        /// <summary>
        /// Date when order was processed 
        /// </summary>
		public DateTime dProcessedOn { get; set; }

        /// <summary>
        /// Days elapsed between order received and order processed 
        /// </summary>
		public Double timeDiff { get; set; }

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double fPostageCost { get; set; }

        /// <summary>
        /// Order total charge 
        /// </summary>
		public Double fTotalCharge { get; set; }

        /// <summary>
        /// Postage cost excluding tax 
        /// </summary>
		public Double PostageCostExTax { get; set; }

        /// <summary>
        /// Order subtotal 
        /// </summary>
		public Double Subtotal { get; set; }

        /// <summary>
        /// Order tax 
        /// </summary>
		public Double fTax { get; set; }

        /// <summary>
        /// Total discount 
        /// </summary>
		public Double TotalDiscount { get; set; }

        /// <summary>
        /// Profit margin 
        /// </summary>
		public Double ProfitMargin { get; set; }

        /// <summary>
        /// Country specific tax rate 
        /// </summary>
		public Double CountryTaxRate { get; set; }

        /// <summary>
        /// Linnworks order ID 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// Order status 
        /// </summary>
		public Int32 nStatus { get; set; }

        /// <summary>
        /// Order currency 
        /// </summary>
		public String cCurrency { get; set; }

        /// <summary>
        /// Postal tracking number 
        /// </summary>
		public String PostalTrackingNumber { get; set; }

        /// <summary>
        /// Country 
        /// </summary>
		public String cCountry { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Postal service code 
        /// </summary>
		public String PostalServiceCode { get; set; }

        /// <summary>
        /// Courier name (e.g. DPD) 
        /// </summary>
		public String Vendor { get; set; }

		public String BillingEmailAddress { get; set; }

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum { get; set; }

        /// <summary>
        /// An additional reference number for the order 
        /// </summary>
		public String SecondaryReference { get; set; }

        /// <summary>
        /// This is an additional reference number from the sales channel, typically used by eBay 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// Order first line of address 
        /// </summary>
		public String Address1 { get; set; }

        /// <summary>
        /// Order second line of address 
        /// </summary>
		public String Address2 { get; set; }

        /// <summary>
        /// Order third line of address 
        /// </summary>
		public String Address3 { get; set; }

        /// <summary>
        /// Town 
        /// </summary>
		public String Town { get; set; }

        /// <summary>
        /// Region, county, area 
        /// </summary>
		public String Region { get; set; }

        /// <summary>
        /// Buyer phone number 
        /// </summary>
		public String BuyerPhoneNumber { get; set; }

        /// <summary>
        /// Company 
        /// </summary>
		public String Company { get; set; }

        /// <summary>
        /// Order subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Channel specific name used to identify the buyer, such as a username, normally used for eBay 
        /// </summary>
		public String ChannelBuyerName { get; set; }

        /// <summary>
        /// Customer channel account name 
        /// </summary>
		public String AccountName { get; set; }

        /// <summary>
        /// Customer full name 
        /// </summary>
		public String cFullName { get; set; }

        /// <summary>
        /// Customer email address 
        /// </summary>
		public String cEmailAddress { get; set; }

        /// <summary>
        /// Post Code 
        /// </summary>
		public String cPostCode { get; set; }

        /// <summary>
        /// When order was marked as PAID 
        /// </summary>
		public DateTime dPaidOn { get; set; }

        /// <summary>
        /// When order was cancelled 
        /// </summary>
		public DateTime dCancelledOn { get; set; }

        /// <summary>
        /// Package category 
        /// </summary>
		public String PackageCategory { get; set; }

        /// <summary>
        /// Package name 
        /// </summary>
		public String PackageTitle { get; set; }

        /// <summary>
        /// Items weight 
        /// </summary>
		public Double ItemWeight { get; set; }

        /// <summary>
        /// Total order weight 
        /// </summary>
		public Double TotalWeight { get; set; }

        /// <summary>
        /// Folder name of an order 
        /// </summary>
		public String FolderCollection { get; set; }

        /// <summary>
        /// Customer billing address 
        /// </summary>
		public String cBillingAddress { get; set; }

        /// <summary>
        /// Customer billing name 
        /// </summary>
		public String BillingName { get; set; }

        /// <summary>
        /// Customer billing company 
        /// </summary>
		public String BillingCompany { get; set; }

        /// <summary>
        /// Billing address line one 
        /// </summary>
		public String BillingAddress1 { get; set; }

        /// <summary>
        /// Billing address line two 
        /// </summary>
		public String BillingAddress2 { get; set; }

        /// <summary>
        /// Billing address line three 
        /// </summary>
		public String BillingAddress3 { get; set; }

        /// <summary>
        /// Billing town 
        /// </summary>
		public String BillingTown { get; set; }

        /// <summary>
        /// Billing region, area, county 
        /// </summary>
		public String BillingRegion { get; set; }

        /// <summary>
        /// Billing postcode 
        /// </summary>
		public String BillingPostCode { get; set; }

        /// <summary>
        /// Billing country 
        /// </summary>
		public String BillingCountryName { get; set; }

        /// <summary>
        /// Billing phone number 
        /// </summary>
		public String BillingPhoneNumber { get; set; }

        /// <summary>
        /// If order on hold or cancelled. 
        /// </summary>
		public Boolean HoldOrCancel { get; set; }

        /// <summary>
        /// If order was created from a resend 
        /// </summary>
		public Boolean IsResend { get; set; }

        /// <summary>
        /// If order was created from an exchange 
        /// </summary>
		public Boolean IsExchange { get; set; }

        /// <summary>
        /// Order tax id 
        /// </summary>
		public String TaxId { get; set; }

        /// <summary>
        /// Order fulfilment location 
        /// </summary>
		public String FulfilmentLocationName { get; set; }
	} 
}