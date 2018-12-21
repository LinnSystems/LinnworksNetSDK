using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRefundRequest
	{
		public Boolean ChannelInitiated;

		public Guid OrderId;

		public List<NewRefundLine> RefundLines;
	} 
}