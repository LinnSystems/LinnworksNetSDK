using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetConfiguratorDataRequest : LinnObject
	{
		public ChannelType ChannelType { get; set; }

		public String ChannelName { get; set; }

		public String DataKey { get; set; }

		public Int32 ConfiguratorId { get; set; }

		public Boolean IgnoreCache { get; set; }
	} 
}