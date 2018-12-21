using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRMAHeader
	{
		public Int32 RMAHeaderId;

		public Guid OrderId;

		public Int32 NumOrderId;

		public String OrderSource;

		public String OrderSubSource;

		public String ExternalReference;

		public Boolean ChannelInitiated;

		public DateTime CreatedDate;

		public PostSaleStatus Status;

		public Boolean Actioned;

		public DateTime LastActionDate;

		public List<VerifiedRMAItem> RMALines;
	} 
}