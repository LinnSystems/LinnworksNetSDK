using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetRefundLinesByHeaderIdResponse
	{
		public Int32 RefundHeaderId;

		public List<VerifiedRefund> RefundLines;

		public RefundOptions RefundOptions;
	} 
}