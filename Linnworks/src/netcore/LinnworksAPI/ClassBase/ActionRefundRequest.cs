using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ActionRefundRequest
	{
		public Int32 RefundHeaderId;

		public Guid OrderId;

		public ActionForm Request;
	} 
}