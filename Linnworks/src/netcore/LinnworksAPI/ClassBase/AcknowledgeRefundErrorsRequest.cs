using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRefundErrorsRequest
	{
		public Int32 RefundHeaderId;

		public List<Guid> RefundRowIds;
	} 
}