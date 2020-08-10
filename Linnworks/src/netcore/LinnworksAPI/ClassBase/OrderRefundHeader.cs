using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRefundHeader
	{
		public Int32 RefundHeaderId;

		public Guid OrderId;

		public Int32 NumOrderId;

		public String ExternalReference;

		public DateTime CreatedDate;

		public String Currency;

		public Decimal Amount;

		public PostSaleStatus Status;

		public Boolean Actioned;

		public DateTime LastActionDate;

		public String OrderSource;

		public String OrderSubSource;

		public Boolean ChannelInitiated;

		public ISet<VerifiedRefund> RefundLines;

		public String RefundLink;
	} 
}