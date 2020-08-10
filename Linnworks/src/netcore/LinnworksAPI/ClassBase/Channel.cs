using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Channel
	{
        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId { get; set; }

        /// <summary>
        /// Postal service name 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Subsource name (e.g. EBAY1) 
        /// </summary>
		public String SubSource { get; set; }
	} 
}