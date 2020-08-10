using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderRMAHeader
	{
		public Int32 RMAHeaderId { get; set; }

		public Guid OrderId { get; set; }

		public Int32 NumOrderId { get; set; }

		public String OrderSource { get; set; }

		public String OrderSubSource { get; set; }

		public String ExternalReference { get; set; }

		public Boolean ChannelInitiated { get; set; }

		public DateTime CreatedDate { get; set; }

		public PostSaleStatus Status { get; set; }

		public Boolean Actioned { get; set; }

		public DateTime LastActionDate { get; set; }

		public List<VerifiedRMAItem> RMALines { get; set; }
	} 
}