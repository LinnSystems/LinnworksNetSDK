using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelReasonBase : LinnObject
	{
		public String Tag { get; set; }

		public String DisplayName { get; set; }

		public List<ChannelSubReason> SubReasons { get; set; }
	} 
}