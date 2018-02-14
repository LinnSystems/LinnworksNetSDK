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
		public Guid pkPostalServiceId;

        /// <summary>
        /// Postal service name 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Subsource name (e.g. EBAY1) 
        /// </summary>
		public String SubSource;
	} 
}