using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelMappingUpdateInfo : LinnObject
	{
        /// <summary>
        /// The unique id to identify the channel mapping 
        /// </summary>
		public Guid? Id { get; set; }

        /// <summary>
        /// Channel reference id. Not updated if not provided. 
        /// </summary>
		public String ChannelReferenceId { get; set; }

        /// <summary>
        /// Maximum listed quantity. Always updated to the value from the request. 
        /// </summary>
		public Int32 MaxListedQuantity { get; set; }

        /// <summary>
        /// End listing when stock level. Always updated to the value from the request. 
        /// </summary>
		public Int32 EndWhenStock { get; set; }

        /// <summary>
        /// Stock percentage. Always updated to the value from the request. 
        /// </summary>
		public Double StockPercentage { get; set; }

        /// <summary>
        /// Ignore sync. Always updated to the value from the request. 
        /// </summary>
		public Boolean IgnoreSync { get; set; }
	} 
}