using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ItemizedRefundReason : LinnObject
	{
		public RefundUnitType Type { get; set; }

		public Guid? ItemId { get; set; }

		public ISet<ChannelReasonBase> Reasons { get; set; }
	} 
}