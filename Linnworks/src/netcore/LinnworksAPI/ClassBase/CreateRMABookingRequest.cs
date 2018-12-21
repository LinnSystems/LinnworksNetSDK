using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRMABookingRequest
	{
		public Boolean ChannelInitiated;

		public Guid OrderId;

		public List<ReturnItem> ReturnItems;

		public List<ExchangeItem> ExchangeItems;

		public List<ResendItem> ResendItems;
	} 
}