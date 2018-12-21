using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ChannelReason
	{
		public String Tag;

		public String DisplayName;

		public ChannelReasonTypes Types;

		public List<ChannelSubReason> SubReasons;
	} 
}