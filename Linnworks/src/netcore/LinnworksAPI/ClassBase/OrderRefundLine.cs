using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRefundLine
	{
		public Guid OrderId;

		public Int32 NOrderId;

		public Int32 ChannelId;

		public String SourceType;

		public String Source;

		public String SubSource;

		public String BuyerFullName;

		public Double OrderSubTotal;

		public Double OrderTotal;

		public String OrderCurrency;

		public Double OrderTaxrate;

		public String SKU;

		public String ChannelSKU;

		public String ItemTitle;

		public DateTime CreateDate;

		public RefundUnitType RefundedUnit;

		public Guid RefundRowId;

		public Guid OrderItemRowId;

		public Double Amount;

		public String Reason;

		public String ChannelReason;

		public String ChannelSubReason;

		public String RefundReference;

		public Int32 CancellationQuantity;

		public Boolean IsActioned;

		public DateTime ActionedDate;

		public PostSaleStatusType Status;

		public Boolean Internal;

		public Boolean IsChannelInitiated;

		public Guid BankId;

		public Boolean AccountingExported;

		public String SubStatusTag;

		public String ErrorMessage;

		public Boolean IsShippingRefund;

		public Boolean IsAdditionalRefund;
	} 
}