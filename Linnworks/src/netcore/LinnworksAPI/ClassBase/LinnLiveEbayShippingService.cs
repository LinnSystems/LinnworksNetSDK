using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class LinnLiveEbayShippingService : LinnObject
	{
		public String ServiceId { get; set; }

		public String ServiceName { get; set; }

		public Boolean isInternationalService { get; set; }

		public Boolean isExpeditedService { get; set; }

		public String ServiceType { get; set; }
	} 
}