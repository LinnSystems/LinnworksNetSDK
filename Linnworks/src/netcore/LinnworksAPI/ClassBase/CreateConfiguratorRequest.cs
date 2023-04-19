using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateConfiguratorRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ConfiguratorName { get; set; }

		public Int32 ChannelId { get; set; }

		public String ChannelName { get; set; }
	} 
}