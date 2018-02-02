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
		public String Tag;

        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public String DisplayName;

        /// <summary>
        /// List of refund reasons 
        /// </summary>
		public List<ChannelRefundSubReason> SubReasons;
	} 
}