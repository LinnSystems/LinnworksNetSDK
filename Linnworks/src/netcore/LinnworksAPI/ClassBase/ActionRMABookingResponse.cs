using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRMABookingResponse
	{
		public List<String> Errors;

		public List<String> Info;

		public Int32 RMAHeaderId;

		public Int32? RefundHeaderId;

		public PostSaleStatus Status;
	} 
}