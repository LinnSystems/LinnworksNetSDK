using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnsRefundsWeb
	{
		public Int32 Row { get; set; }

		public Guid pkOrderID { get; set; }

		public String cShippingAddress { get; set; }

		public DateTime dProcessedOn { get; set; }

		public Double fPostageCost { get; set; }

		public Double fTotalCharge { get; set; }

		public Double PostageCostExTax { get; set; }

		public Double Subtotal { get; set; }

		public Double fTax { get; set; }

		public Double TotalDiscount { get; set; }

		public Double CountryTaxRate { get; set; }

		public Int32 nOrderId { get; set; }

		public String cCurrency { get; set; }

		public String PostalTrackingNumber { get; set; }

		public String cCountry { get; set; }

		public String Source { get; set; }

		public String PostalServiceName { get; set; }

		public String PostalServiceCode { get; set; }

		public String Vendor { get; set; }

		public String ReferenceNum { get; set; }

		public String SecondaryReference { get; set; }

		public String ExternalReference { get; set; }

		public String Address1 { get; set; }

		public String Address2 { get; set; }

		public String Address3 { get; set; }

		public String Town { get; set; }

		public String Region { get; set; }

		public String BuyerPhoneNumber { get; set; }

		public String Company { get; set; }

		public String SubSource { get; set; }

		public String ChannelBuyerName { get; set; }

		public String AccountName { get; set; }

		public String cFullName { get; set; }

		public String cEmailAddress { get; set; }

		public String cPostCode { get; set; }

		public DateTime dPaidOn { get; set; }

		public String cBillingAddress { get; set; }

		public String BillingName { get; set; }

		public String BillingCompany { get; set; }

		public String BillingAddress1 { get; set; }

		public String BillingAddress2 { get; set; }

		public String BillingAddress3 { get; set; }

		public String BillingTown { get; set; }

		public String BillingRegion { get; set; }

		public String BillingPostCode { get; set; }

		public String BillingCountryName { get; set; }

		public String BillingPhoneNumber { get; set; }

		public String cItemNumber { get; set; }

		public String cItemName { get; set; }

		public Int32 pkReturnId { get; set; }

		public String RowType { get; set; }

		public String ReturnReference { get; set; }

		public Double PendingRefundAmount { get; set; }

		public DateTime LastDate { get; set; }

		public String Reason { get; set; }

		public String ChannelReason { get; set; }

		public String ChannelReasonSec { get; set; }

		public String Category { get; set; }

		public Int32 ReturnQty { get; set; }

		public Guid fkReturnLocationId { get; set; }

		public Boolean Scrapped { get; set; }

		public Int32? ScrapQty { get; set; }

		public DateTime ReturnDate { get; set; }

		public String Location { get; set; }

		public String ItemNumber { get; set; }

		public String ItemTitle { get; set; }

		public Int32 NewQty { get; set; }

		public String RefundReference { get; set; }

		public Guid pkRefundRowId { get; set; }

		public Double Amount { get; set; }

		public DateTime CreateDate { get; set; }

		public Int32 CancellationQuantity { get; set; }

		public Guid fkOrderItemReturnId { get; set; }

		public DateTime ActionDate { get; set; }

		public PostSaleStatusType RefundStatus { get; set; }
	} 
}