using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRMABookingRequest
	{
		public Int32 RMAHeaderId;

		public Guid OrderId;

		public ActionForm Request;
	} 
}