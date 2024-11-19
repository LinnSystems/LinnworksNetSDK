using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScheduledDelivery : LinnObject
	{
		public DateTime? From { get; set; }

		public DateTime? To { get; set; }
	} 
}