using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateRMABookingRequest
	{
		public Guid OrderId;

		public Int32 RMAHeaderId;

		public List<UpdatedReturnItem> ReturnItems;

		public List<UpdatedExchangeItem> ExchangeItems;

		public List<UpdatedResendItem> ResendItems;

		public Boolean AllowCreationOfNewOrder;
	} 
}