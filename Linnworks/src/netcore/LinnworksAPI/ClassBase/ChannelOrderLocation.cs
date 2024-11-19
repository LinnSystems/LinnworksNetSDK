using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelOrderLocation : LinnObject
	{
		public String ExternalReference { get; set; }

		public List<ChannelOrderItemLocationAllocation> ItemAllocations { get; set; }
	} 
}