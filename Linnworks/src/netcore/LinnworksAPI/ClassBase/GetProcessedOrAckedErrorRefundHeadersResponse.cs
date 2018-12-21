using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProcessedOrAckedErrorRefundHeadersResponse
	{
		public Int32 Page;

		public Int32 TotalHeaders;

		public Int32 HeadersPerPage;

		public List<OrderRefundHeader> RefundHeaders;
	} 
}