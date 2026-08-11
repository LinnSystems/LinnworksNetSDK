using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelOrderLocation : LinnObject
	{
        /// <summary>
        /// The order location id on the channel. 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// The item and quantity allocation.
        /// Only required if order is multi-location. 
        /// </summary>
		public List<ChannelOrderItemLocationAllocation> ItemAllocations { get; set; }
	} 
}