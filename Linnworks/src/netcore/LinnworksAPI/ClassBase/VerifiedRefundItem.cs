using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VerifiedRefundItem
	{
		public Guid OrderItemRowId;

		public Int32? ReturnRowId;

		public String ItemSKU;

		public String ChannelSKU;

		public String ItemTitle;

		public Decimal Cost;

		public Int32 CancelledQuantity;
	} 
}