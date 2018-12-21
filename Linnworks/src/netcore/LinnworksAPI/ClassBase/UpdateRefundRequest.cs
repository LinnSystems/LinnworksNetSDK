using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateRefundRequest
	{
		public Int32 RefundHeaderId;

		public Guid OrderId;

		public List<UpdatedRefundLine> RefundLines;
	} 
}