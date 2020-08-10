using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelRefundReason
	{
        /// <summary>
        /// Refund reason tag 
        /// </summary>
		public String Tag { get; set; }

        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public String DisplayName { get; set; }

        /// <summary>
        /// List of refund reasons 
        /// </summary>
		public List<ChannelRefundSubReason> SubReasons { get; set; }
	} 
}