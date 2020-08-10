using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelServiceLinks
	{
        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Channel { get; set; }

        /// <summary>
        /// Subsource (e.g. EBAY1) 
        /// </summary>
		public String ChannelName { get; set; }

        /// <summary>
        /// Channel shipping service name 
        /// </summary>
		public String ChannelService { get; set; }

        /// <summary>
        /// Channel shpping service tag 
        /// </summary>
		public String ChannelTag { get; set; }

        /// <summary>
        /// Channel site 
        /// </summary>
		public String Site { get; set; }
	} 
}