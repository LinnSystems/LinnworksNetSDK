using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelReason : LinnObject
	{
		public ChannelReasonTypes Types { get; set; }

		public String Tag { get; set; }

		public String DisplayName { get; set; }

		public List<ChannelSubReason> SubReasons { get; set; }
	} 
}